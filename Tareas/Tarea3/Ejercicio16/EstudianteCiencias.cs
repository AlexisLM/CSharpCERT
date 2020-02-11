using System;

/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

namespace Ejercicio16
{
    class EstudianteCiencias : Estudiante
    {
        /// <summary>
        /// Constructor de un EstudianteCiencias.
        /// </summary>
        /// <param name="nombreCompleto">Nombre completo.</param>
        /// <param name="edad">Edad.</param>
        /// <param name="numeroCuenta">Número de cuenta.</param>
        public EstudianteCiencias(string nombreCompleto, ushort edad,
            int numeroCuenta) : base(nombreCompleto, edad, numeroCuenta) { }

        /// <summary>
        /// Imprime un mensaje de que el estudiante está estudiando.
        /// </summary>
        public override void Estudia()
        {
            Console.WriteLine($"El estudiante {NombreCompleto} está " +
                "estudiando Ciencias exactas.");
        }

        /// <summary>
        /// Imprime un mensaje de que el estudiante está haciendo tarea.
        /// </summary>
        public override void Tarea()
        {
            Console.WriteLine($"El estudiante {NombreCompleto} hace tarea " +
                "de cálculo.");
        }

        /// <summary>
        /// Imprime un mensaje de que el estudiante no duerme.
        /// </summary>
        public override void Dormir()
        {
            Console.WriteLine($"El estudiante {NombreCompleto} no duerme.");
        }
    }
}
