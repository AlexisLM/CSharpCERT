using System;

/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

namespace Ejercicio3
{
    class Program
    {
        /// <summary>
        /// Appends an f before each vowel.
        /// </summary>
        /// <param name="str">String to append letters f.</param>
        private static void AppendFBeforeVowels(string str)
        {
            char[] vowels = { 'A', 'E', 'I', 'O', 'U', 'Á', 'É', 'Í', 'Ó',
                'Ú' };
            foreach (char c in str)
            {
                if ($"{c}".ToUpper().IndexOfAny(vowels) != -1)
                    Console.Write("f");
                Console.Write(c);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Excercise 3.");

            // Get Input
            Console.Write("Enter a phrase: ");
            string str = Console.ReadLine();

            // Generate output
            AppendFBeforeVowels(str);

            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
