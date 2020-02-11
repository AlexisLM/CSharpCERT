using System;

/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Excercise 16.");
            Estudiante estudiante = new Estudiante("Alan Brito Delgado",
                20, 313237896);
            EstudianteIngenieria ingenieria = new EstudianteIngenieria(
                "Armando Hoyos López", 22, 365348892);
            EstudianteCiencias ciencias = new EstudianteCiencias("Elsa Pato " +
                "García", 21, 314657492);

            // Estudia
            estudiante.Estudia();
            ingenieria.Estudia();
            ciencias.Estudia();

            // Tarea
            Console.WriteLine();
            estudiante.Tarea();
            ingenieria.Tarea();
            ciencias.Tarea();

            // Dormir
            Console.WriteLine();
            estudiante.Dormir();
            ingenieria.Dormir();
            ciencias.Dormir();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
