using System;
using System.Collections.Generic;

/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

namespace Ejercicio5
{
    static class Phonebook
    {
        private static Dictionary<string, string> phonebook = new
            Dictionary<string, string>();

        /// <summary>
        /// Prompts a name to the user and adds or update its respective
        /// contact.
        /// </summary>
        private static void AddContact()
        {
            // Name and phone number from user input
            string name = GetStringFromSTDIN("Enter name: ");
            string number = GetStringFromSTDIN("Enter number: ");

            if (phonebook.ContainsKey(name)) // Update contact
            {
                phonebook[name] = number;
                Console.WriteLine($"Contact {name} updated successfully!");
            }
            else // Add contact
            {
                phonebook.Add(name, number);
                Console.WriteLine("Contact added successfully");
            }
        }

        /// <summary>
        /// Prompts a name to the user and deletes its respective contact.
        /// </summary>
        private static void DeleteContact()
        {
            string name = GetStringFromSTDIN("Enter name: "); // Contact name

            // Try to delete contact
            if (phonebook.Remove(name))
                Console.WriteLine("Contact has been deleted successfully");
            else
                Console.WriteLine("Contact not found.");
        }

        /// <summary>
        /// Prompts a name to the user and shows its respective contact.
        /// </summary>
        private static void ShowContact()
        {
            string name = GetStringFromSTDIN("Enter name: "); // Contact name

            // Try to get contact
            if (phonebook.ContainsKey(name))
                Console.WriteLine($"{name}: {phonebook[name]}");
            else
                Console.WriteLine("Contact not found.");
        }

        /// <summary>
        /// Prints <paramref name="msg"/> to STDOUT and gets the user input.
        /// </summary>
        /// <param name="msg">Message to print.</param>
        /// <returns>User input</returns>
        private static string GetStringFromSTDIN(string msg)
        {
            string str = ""; // Input string

            // Get str from user input
            while (str.Equals(""))
            {
                Console.Write(msg);
                str = Console.ReadLine();
            }

            return str;
        }

        /// <summary>
        /// Prints menu with the available options.
        /// </summary>
        private static void PrintMenu()
        {
            string menu = "\nSelect one of the following options: [1-4]\n" +
                "1] Add contact.\n2] Delete contact.\n3] Show contact.\n" +
                "4] Exit.\n----------------------------------------\nOption: ";
            Console.Write(menu);
        }

        /// <summary>
        /// Runs Phonebook program.
        /// </summary>
        public static void Run()
        {
            string input = ""; // Selected option

            while (!input.Equals("4"))
            {
                PrintMenu(); // Show available options
                input = Console.ReadLine(); // Get selected option
                Console.WriteLine("");

                switch (input)
                {
                    case "1": // Add contact
                        AddContact();
                        break;
                    case "2": // Delete contact
                        DeleteContact();
                        break;
                    case "3": // Show contact
                        ShowContact();
                        break;
                    case "4": // Exit
                        Console.WriteLine("See you!");
                        break;
                }
            }
        }
    }
}
