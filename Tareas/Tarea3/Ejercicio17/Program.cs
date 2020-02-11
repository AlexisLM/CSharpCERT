using System;

/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Excercise 17.");
            Persona persona = new Persona("Armando Hoyos Parado", 28);
            Estudiante estudiante = new Estudiante("Alan Brito Delgado",
                20, 313237896);
            Trabajador trabajador = new Trabajador("Elsa Pato García", 30,
                "VECJ880326 XXX");

            // ToString
            Console.WriteLine(persona);
            Console.WriteLine(estudiante);
            Console.WriteLine(trabajador);

            // Respirar
            Console.WriteLine();
            persona.Respirar();
            estudiante.Respirar();
            trabajador.Respirar();

            // Comer
            Console.WriteLine();
            persona.Comer();
            estudiante.Comer();
            trabajador.Comer();

            // Dormir
            Console.WriteLine();
            persona.Dormir();
            estudiante.Dormir();
            trabajador.Dormir();

            // Hacer actividad
            Console.WriteLine();
            persona.HacerActividad();
            estudiante.HacerActividad();
            trabajador.HacerActividad();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
