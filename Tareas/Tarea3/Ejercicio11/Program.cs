using System;

/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

namespace Ejercicio11
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Excercise 11.");

            try
            {
                MatrixCalculator.Run(); // Run Matrix Calculator
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is OverflowException)
                    Console.WriteLine("You must provide a positive number");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}
