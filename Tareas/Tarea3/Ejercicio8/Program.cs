using System;

/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Excercise 8.");
            // Create autos
            Auto auto1 = new Auto("Audi A8", "Black", "AWL-F0-Z4");
            Auto auto2 = new Auto("Mazda RX-7", "Red", "QWE-T8-AF");
            Auto auto3 = new Auto("Mercedez R350", "White", "AZS-98-W7");

            Console.WriteLine(auto1);
            Console.WriteLine(auto2);
            Console.WriteLine(auto3);

            // Accelerate
            Console.WriteLine("\nAccelerating...");
            auto1.Accelerate(10.0);
            auto2.Accelerate(5.0);
            auto3.Accelerate(2.0);
            Console.WriteLine($"{auto1.Plate} => Speed: {auto1.Speed}km/h");
            Console.WriteLine($"{auto2.Plate} => Speed: {auto2.Speed}km/h");
            Console.WriteLine($"{auto3.Plate} => Speed: {auto3.Speed}km/h");

            // Start
            Console.WriteLine("\nStarting engine...");
            auto1.Start();
            auto2.Start();
            auto3.Start();
            Console.WriteLine(auto1);
            Console.WriteLine(auto2);
            Console.WriteLine(auto3);

            // Turn off
            Console.WriteLine("\nTurning off engine...");
            auto1.TurnOff();
            auto2.TurnOff();
            auto3.TurnOff();
            Console.WriteLine(auto1);
            Console.WriteLine(auto2);
            Console.WriteLine(auto3);

            // Turn left
            Console.WriteLine("\nTurning left...");
            auto1.TurnLeft();
            auto2.TurnLeft();
            auto3.TurnLeft();
            Console.WriteLine(auto1);
            Console.WriteLine(auto2);
            Console.WriteLine(auto3);

            // Turn right
            Console.WriteLine("\nTurning right...");
            auto1.TurnRight();
            auto2.TurnRight();
            auto3.TurnRight();
            Console.WriteLine(auto1);
            Console.WriteLine(auto2);
            Console.WriteLine(auto3);

            // Go Forward
            Console.WriteLine("\nGoing forward...");
            auto1.GoForward();
            auto2.GoForward();
            auto3.GoForward();
            Console.WriteLine(auto1);
            Console.WriteLine(auto2);
            Console.WriteLine(auto3);

            // Setters
            Console.WriteLine("\nPainting... (Setters)");
            auto1.Color = "Cyan";
            auto2.Color = "Purple";
            auto3.Color = "Pink";
            Console.WriteLine($"{auto1.Plate} => Color: {auto1.Color}");
            Console.WriteLine($"{auto2.Plate} => Color: {auto2.Color}");
            Console.WriteLine($"{auto3.Plate} => Color: {auto3.Color}");

            // Getters
            Console.WriteLine("\nGetters:");
            Console.WriteLine($"{auto1.Plate}" +
                $"\n\t=> Model: {auto1.Model}" +
                $"\n\t=> Color: {auto1.Color}" +
                $"\n\t=> State: {auto1.State}" +
                $"\n\t=> Direction: {auto1.Direction}" +
                $"\n\t=> Speed: {auto1.Speed}km/h");
            Console.WriteLine($"{auto2.Plate}" +
                $"\n\t=> Model: {auto2.Model}" +
                $"\n\t=> Color: {auto2.Color}" +
                $"\n\t=> State: {auto2.State}" +
                $"\n\t=> Direction: {auto2.Direction}" +
                $"\n\t=> Speed: {auto2.Speed}km/h");
            Console.WriteLine($"{auto3.Plate}" +
                $"\n\t=> Model: {auto3.Model}" +
                $"\n\t=> Color: {auto3.Color}" +
                $"\n\t=> State: {auto3.State}" +
                $"\n\t=> Direction: {auto3.Direction}" +
                $"\n\t=> Speed: {auto3.Speed}km/h");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
