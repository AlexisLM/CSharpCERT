using System;
using System.Collections.Generic;
using System.IO;

/**
 * Tarea 4.
 * Autor: Alexis Brayan López Matías.
 */

namespace Tarea4
{
    /// <summary>
    /// Class that emulates a Windows Console (CMD).
    /// Supported commands:
    /// <list type="bullet">
    /// <item>
    /// <term>dir [DIRECTORY]</term>
    /// <description>Lists contents of the DIRECTORY.</description>
    /// </item>
    /// <item>
    /// <term>cd DIRECTORY</term>
    /// <description>Changes current directory to DIRECTORY.</description>
    /// </item>
    /// <item>
    /// <term>touch FILE_NAME</term>
    /// <description>Creates/Overwrites FILENAME.</description>
    /// </item>
    /// <item>
    /// <term>move SRC_FILE DEST_FILE</term>
    /// <description>Move SRC_FILE to DEST_FILE.</description>
    /// </item>
    /// <item>
    /// <term>history</term>
    /// <description>Shows the command history.</description>
    /// </item>
    /// <item>
    /// <term>cls</term>
    /// <description>Clears screen.</description>
    /// </item>
    /// <item>
    /// <term>exit</term>
    /// <description>Exit.</description>
    /// </item>
    /// </list>
    /// </summary>
    class ConsoleEmulator
    {
        /// <summary>Current working directory.</summary>
        private string Path_ { get; set; }

        /// <summary>Command Arguments.</summary>
        private readonly string[] Arguments;

        /// <summary>Directory separators characters.</summary>
        private readonly char[] DirSeparatorsChars;

        /// <summary>Command history.</summary>
        private readonly List<string> CommandHistory;

        /// <summary>Available commands.</summary>
        private enum Commands
        {
            DIR,        // List directory
            CD,         // Change directory
            TOUCH,      // Create/Overwrite file
            MOVE,       // Move file
            HISTORY,    // Command history
            CLS,        // Clear screen
            EXIT,       // Exit
            LINEBREAK   // Empty strings
        }

        /// <summary>
        /// ConsoleEmulartor constructor.
        /// </summary>
        public ConsoleEmulator()
        {
            Path_ = Environment.GetFolderPath(Environment.SpecialFolder
                .MyDocuments);                      // Inital path (Documents)
            Arguments = new string[] { "", "" };    // Command arguments
            
            // Directory Separators Characters
            DirSeparatorsChars = new char[] { Path.DirectorySeparatorChar,
                                              Path.AltDirectorySeparatorChar };
            CommandHistory = new List<string>();    // Command history
        }

        /// <summary>
        /// Prints the prompt.
        /// </summary>
        private void PrintPrompt()
        {
            Console.Write($"{Path_}> ");
        }

        /// <summary>
        /// List content of the current directory.
        /// </summary>
        private void Dir()
        {
            string[] files; // File paths
            string[] dirs;  // Directory paths 

            if (string.IsNullOrWhiteSpace(Arguments[0])) // No arguments
            {
                files = Directory.GetFiles(Path_);
                dirs = Directory.GetDirectories(Path_);
            }
            else if (File.Exists(Path.Combine(Path_, Arguments[0])))
                throw new DirectoryNotFoundException(); // Is a file
            else // Is a directory
            {
                files = Directory.GetFiles(Path.Combine(Path_, Arguments[0]));
                dirs = Directory.GetDirectories(Path.Combine(Path_,
                    Arguments[0]));
            }

            // Print directories
            Console.WriteLine("Directories:");
            foreach (string dir in dirs)
                Console.WriteLine($"\t{ dir.Split(DirSeparatorsChars)[^1] }");

            // Print files
            Console.WriteLine("\nFiles:");
            foreach (string file in files)
                Console.WriteLine($"\t{Path.GetFileName(file)}");
        }

        /// <summary>
        /// Clears the console screen.
        /// </summary>
        private void Cls()
        {
            Console.Clear();
        }

        /// <summary>
        /// Shows the command history.
        /// </summary>
        private void History()
        {
            foreach (string statement in CommandHistory)
                Console.WriteLine(statement);
        }

        /// <summary>
        /// Moves a source file to destination file.
        /// </summary>
        private void Move()
        {
            string src_file = Path.Combine(Path_, Arguments[0]); // Src. file
            string dst_file = Path.Combine(Path_, Arguments[1]); // Dest. file
            bool overwrite = false; // Flag to overwrite file

            if (string.IsNullOrWhiteSpace(Arguments[0])) // Not src. file
                throw new FormatException("Error: You must provide the " +
                    "source path.");

            if (string.IsNullOrWhiteSpace(Arguments[1])) // Not dest. file
                throw new FormatException("Error: You must provide the " +
                    "destination path.");

            if (!File.Exists(src_file)) // Src. file doesn't exist
                throw new FileNotFoundException();

            if (Directory.Exists(dst_file)) // Dest. file is a directory
                dst_file = Path.Combine(dst_file, Path.GetFileName(src_file));
            
            if (File.Exists(dst_file)) // File already exists
            {
                Console.Write("File already exists! Do you want to " +
                    "replace it? [Y/N]: ");
                overwrite = Console.ReadLine().Trim().ToUpper().Equals("Y");
            }

            if (!File.Exists(dst_file) || overwrite) // Move file
                File.Move(src_file, dst_file, overwrite);
        }

        /// <summary>
        /// Creates or overwrites a file.
        /// </summary>
        private void Touch()
        {
            string dst_file = Path.Combine(Path_, Arguments[0]); // Dest. file
            bool overwrite = false; // Flag to overwrite file

            if (string.IsNullOrWhiteSpace(Arguments[0])) // No dest. file
                throw new FormatException("Error: You must provide the " +
                    "destination path.");

            if (File.Exists(dst_file)) // File already exists
            {
                Console.Write("File already exists! Do you want to " +
                    "replace it? [Y/N]: ");
                overwrite = Console.ReadLine().Trim().ToUpper().Equals("Y");
            }

            if (!File.Exists(dst_file) || overwrite) // Create file
                File.Create(dst_file).Close();
        }

        /// <summary>
        /// Changes the current directory.
        /// </summary>
        private void Cd()
        {
            string newpath = Path.Combine(Path_, Arguments[0]); // Dest. Path
            
            if (File.Exists(newpath)) // Is a file
                throw new DirectoryNotFoundException();
            else if (Directory.Exists(newpath))// Is a directory
                Path_ = Path.GetFullPath(newpath);
            else // Directory not found
                throw new DirectoryNotFoundException();
        }

        /// <summary>
        /// Process the user input and returns the command to execute.
        /// </summary>
        /// <returns>
        /// Returns the Commands enum asociated to the command to execute.
        /// </returns>
        private Commands ProcessStatement()
        {
            string statement = Console.ReadLine(); // User input
            string[] tokens = statement.Trim().Split(" "); // Tokens
            Commands command = (Commands)(-1); // Init with invalid command
            Arguments[0] = ""; // Init first argument
            Arguments[1] = ""; // Init second argument

            if (!string.IsNullOrWhiteSpace(statement)) // It isn't an empty str
            {
                CommandHistory.Add(statement); // Add to command history

                if (tokens[0].Equals("dir")) // Dir
                {
                    command = Commands.DIR;
                    Arguments[0] = tokens.Length > 1 ? tokens[1] : "";
                }
                else if (tokens[0].Equals("cd")) // Cd
                {
                    command = Commands.CD;
                    Arguments[0] = tokens.Length > 1 ? tokens[1] : "";
                }
                else if (tokens[0].Equals("touch")) // Touch
                {
                    command = Commands.TOUCH;
                    Arguments[0] = tokens.Length > 1 ? tokens[1] : "";
                }
                else if (tokens[0].Equals("move")) // Move
                {
                    command = Commands.MOVE;
                    Arguments[0] = tokens.Length > 1 ? tokens[1] : "";
                    Arguments[1] = tokens.Length > 2 ? tokens[2] : "";
                }
                else if (tokens[0].Equals("history")) // History
                    command = Commands.HISTORY;

                else if (tokens[0].Equals("cls")) // Cls
                    command = Commands.CLS;

                else if (tokens[0].Equals("exit")) // Exit
                    command = Commands.EXIT;
            }
            else // Line break
                command = Commands.LINEBREAK;

            return command;
        }

        /// <summary>
        /// Starts the console emulator.
        /// </summary>
        public void Run()
        {
            try
            {
                Commands command; // Command to execute
                PrintPrompt(); // Print prompt

                while ((command = ProcessStatement()) != Commands.EXIT)
                {
                    if (command == Commands.DIR) // List directory
                        Dir();
                    else if (command == Commands.CD) // Change directory
                        Cd();
                    else if (command == Commands.TOUCH) // Create/Overwrite f.
                        Touch();
                    else if (command == Commands.MOVE) // Move file
                        Move();
                    else if (command == Commands.HISTORY) // List command hist.
                        History();
                    else if (command == Commands.CLS) // Clear screen
                        Cls();
                    else if(command != Commands.LINEBREAK) // Show input error
                        Console.WriteLine("Error: Command " +
                            $"{CommandHistory[^1]} not found.");

                    Console.WriteLine(); // Line break
                    PrintPrompt(); // Print prompt
                }
            }
            catch (PlatformNotSupportedException)
            {
                Console.WriteLine("Error: Platform not supported.\n");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Error: Unauthorized Access.\n");
                Run();
            }
            catch (System.Security.SecurityException)
            {
                Console.WriteLine("Error: Unauthorized Access.\n");
                Run();
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Error: Path is too long.\n");
                Run();
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Error: Directory not found.\n");
                Run();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Error: File {Arguments[0]} not found.\n");
                Run();
            }
            catch (FormatException fe)
            {
                Console.WriteLine($"{fe.Message}\n");
                Run();
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("ERROR: Path has invalid chars.\n");
                Run();
            }
            catch (IOException)
            {
                Console.WriteLine("ERROR: Invalid input.\n");
                Run();
            }
        }
    }
}
