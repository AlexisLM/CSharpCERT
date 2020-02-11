using System;

/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

namespace Ejercicio2
{
    class Program
    {
        /// <summary>
        /// Verify if <paramref name="number"/> is multiple of
        /// <paramref name="match"/> or it contains <paramref name="match"/>.
        /// </summary>
        /// <param name="number">Number to analize.</param>
        /// <param name="match">Number to match.</param>
        /// <returns></returns>
        private static bool MatchNumber(int number, int match)
        {
            return (number % match == 0) || ($"{number}".Contains($"{match}"));
        }

        /// <summary>
        /// Print all numbers between 1 and 100 but if the number is multiple 
        /// of <paramref name="n1"/> or <paramref name="n2"/>, or it contains
        /// one of them, the program prints 'clap'.
        /// </summary>
        /// <param name="n1">Number between 1 and 9 to check matches.</param>
        /// <param name="n2">Number between 1 and 9 to check matches.</param>
        /// <exception cref="System.FormatException">
        /// Thrown when <paramref name="n1"/> or <paramref name="n2"/> are
        /// not between 1 and 9.
        /// </exception>
        private static void PrintNumberList(int n1, int n2)
        {
            if (n1 < 1 || n1 > 9 || n2 < 1 || n2 > 9)
                throw new FormatException();

            int number = 1;
            for (; number <= 100; number++)
            {
                if (MatchNumber(number, n1) || MatchNumber(number, n2))
                    Console.WriteLine("clap");
                else
                    Console.WriteLine(number);
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Excercise 2.");
            try
            {
                // Get input
                Console.Write("Enter a number between 1 and 9: ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number between 1 and 9: ");
                int n2 = Convert.ToInt32(Console.ReadLine());

                // Generate output
                PrintNumberList(n1, n2);
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR: You must provide a number between " +
                    "1 and 9.");
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
