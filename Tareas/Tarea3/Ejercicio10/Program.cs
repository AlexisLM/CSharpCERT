using System;

/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

namespace Ejercicio10
{
    class Program
    {
        /// <summary>
        /// Imprime <paramref name="msg"/> a la salida estándar y obtiene la
        /// entrada del usuario.
        /// </summary>
        /// <param name="msg">Mensaje a imprimir.</param>
        /// <returns>Entrada del usuario.</returns>
        private static string GetStringFromSTDIN(string msg)
        {
            string str = ""; // Entrada del usuario

            // Obtener entrada del usuario
            while (str.Equals(""))
            {
                Console.Write(msg);
                str = Console.ReadLine();
            }

            return str;
        }

        /// <summary>
        /// Imprime <paramref name="msg"/> a la salida estándar y obtiene la
        /// entrada del usuario.
        /// </summary>
        /// <param name="msg">Mensaje a imprimir.</param>
        /// <returns>Entrada del usuario.</returns>
        private static double GetDoubleFromSTDIN(string msg)
        {
            double dbl = 0; // Salida

            // Obtener entrada del usuario
            while (dbl <= 0)
            {
                Console.Write(msg);
                dbl = double.TryParse(Console.ReadLine(), out dbl) ? dbl : 0;
            }

            return dbl;
        }

        /// <summary>
        /// Imprime <paramref name="msg"/> a la salida estándar y obtiene la
        /// entrada del usuario.
        /// </summary>
        /// <param name="msg">Mensaje a imprimir.</param>
        /// <returns>Entrada del usuario.</returns>
        private static ushort GetUShortFromSTDIN(string msg)
        {
            ushort usht = 0; // Salida

            // Obtener entrada del usuario
            while (usht <= 0)
            {
                Console.Write(msg);
                usht = ushort.TryParse(Console.ReadLine(), out usht) ? usht :
                    (ushort)0;
            }

            return usht;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Excercise 10.");
            // Pruebas
            Persona persona = new Persona(
                GetStringFromSTDIN("Ingrese nombre: "),
                GetUShortFromSTDIN("Ingrese edad (en años): "),
                GetDoubleFromSTDIN("Ingrese estatura (en metros): "),
                GetDoubleFromSTDIN("Ingrese peso (en kg): "));

            Console.WriteLine($"\nToString: {persona}");
            persona.Saludar();
            persona.Dormir();
            persona.Despertar();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
