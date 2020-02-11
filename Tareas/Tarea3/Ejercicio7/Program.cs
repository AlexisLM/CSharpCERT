using System;

/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Excercise 7.");
            // Creamos números complejos
            NumeroComplejo c1 = new NumeroComplejo(1, 2);
            NumeroComplejo c2 = new NumeroComplejo(1, 2);

            // Impresiones
            Console.WriteLine("Impresiones:");
            Console.Write("c1: ");
            c1.Imprimir();
            Console.Write("c2: ");
            c2.Imprimir();

            // Suma
            Console.Write("\nSuma:\nc1 + c2: ");
            NumeroComplejo c3 = NumeroComplejo.Suma(c1, c2);
            c3.Imprimir();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
