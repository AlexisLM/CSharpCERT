using System;

/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

namespace Ejercicio1
{
    class Program
    {
        /// <summary>
        /// Add the first N natural numbers.
        /// </summary>
        /// <param name="n">Total of natural numbers to be added.</param>
        /// <returns>The sum of the first N natural numbers.</returns>
        /// <exception cref="System.FormatException">
        /// Thrown when n is lower than 0.
        /// </exception>
        private static int SumOfFirstNNumbers(int n)
        {
            if (n < 0)
                throw new FormatException();
            return (n * (n + 1)) / 2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Excercise 1.");
            try
            {
                // Get input
                Console.Write("Enter a natural number: ");
                int n = Convert.ToInt32(Console.ReadLine());

                // Generate output
                Console.WriteLine("The sum of the first {0} numbers is: {1}",
                    n, SumOfFirstNNumbers(n));
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR: You must provide a natural number.");
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
