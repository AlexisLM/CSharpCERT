using System;

/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Excercise 13.");
            Carro carro = new Carro(1000, 1.5);
            CarroBMW carroBMW = new CarroBMW(1500, 1.25, "BMW i8");
            CarroVW carroVW = new CarroVW(1700, 1.75, "Polo");

            // Encender
            Console.WriteLine("Enceder:");
            carro.Encender();
            carroBMW.Encender();
            carroVW.Encender();

            // Apagar
            Console.WriteLine("\nApagar:");
            carro.Apagar();
            carroBMW.Apagar();
            carroVW.Apagar();

            // Estado
            Console.WriteLine("\nEstado:");
            carro.Estado();
            carroBMW.Estado();
            carroVW.Estado();

            // ToString
            Console.WriteLine("\nToString:");
            Console.WriteLine(carro);
            Console.WriteLine("\n" + carroBMW);
            Console.WriteLine("\n" + carroVW);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
