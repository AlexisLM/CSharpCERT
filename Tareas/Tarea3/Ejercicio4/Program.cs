using System;

/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

namespace Ejercicio4
{
    class Program
    {
        /// <summary>
        /// Prints first <paramref name="n"/> Fibonacci terms.
        /// </summary>
        /// <param name="n">Last fibonacci term to print.</param>
        /// <exception cref="System.FormatException">
        /// Thrown when <paramref name="n"/> is lower than 0.
        /// </exception>
        static void FirstNFibonacciTerms(uint n)
        {
            if (n < 0)
                throw new FormatException();

            // Vars to calculate fibonaccie sequence.
            ulong fib_term = 0, prev_1 = 0, prev_2 = 0, i = 0;

            Console.WriteLine($"Fibonacci Sequence until term {n}:");
            for (; i <= n; i++)
            {
                Console.WriteLine($"f{i} = {fib_term}");
                
                // Current term (Fn = Fn-1 + Fn-2)
                fib_term = fib_term == 0 ? 1 : prev_1 + prev_2;
                prev_2 = prev_1; // Fn-1
                prev_1 = fib_term; // Fn-2
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Excercise 4.");
            try
            {
                // Get input
                Console.Write("Enter a number: ");
                uint n = Convert.ToUInt32(Console.ReadLine());

                // Generate output
                FirstNFibonacciTerms(n);
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR: You must provide a positive number.");
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
