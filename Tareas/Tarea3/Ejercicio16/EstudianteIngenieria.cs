using System;

/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

namespace Ejercicio16
{
    class EstudianteIngenieria : Estudiante
    {
        /// <summary>
        /// Constructor de un EstudianteIngenieria.
        /// </summary>
        /// <param name="nombreCompleto">Nombre completo.</param>
        /// <param name="edad">Edad.</param>
        /// <param name="numeroCuenta">Número de cuenta.</param>
        public EstudianteIngenieria(string nombreCompleto, ushort edad,
            int numeroCuenta) : base(nombreCompleto, edad, numeroCuenta) { }

        /// <summary>
        /// Imprime un mensaje de que el estudiante está estudiando.
        /// </summary>
        public override void Estudia()
        {
            Console.WriteLine($"El estudiante {NombreCompleto} está " +
                "estudiando Ingeniería.");
        }

        /// <summary>
        /// Imprime un mensaje de que el estudiante está haciendo tarea.
        /// </summary>
        public override void Tarea()
        {
            Console.WriteLine($"El estudiante {NombreCompleto} hace tarea " +
                "de física.");
        }

        /// <summary>
        /// Imprime un mensaje de que el estudiante duerme.
        /// </summary>
        public override void Dormir()
        {
            Console.WriteLine($"El estudiante {NombreCompleto} duerme " +
                "(según).");
        }
    }
}
