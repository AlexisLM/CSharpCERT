using System;

/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

namespace Ejercicio16
{
    class Estudiante
    {
        /// <summary>Nombre completo del estudiante.</summary>
        public string NombreCompleto { get; set; }

        /// <summary>Edad del estudiante.</summary>
        public ushort Edad { get; set; }

        /// <summary>Número de cuenta del estudiante.</summary>
        public int NumeroCuenta { get; set; }

        /// <summary>
        /// Constructor de un Estudiante.
        /// </summary>
        /// <param name="nombreCompleto">Nombre completo.</param>
        /// <param name="edad">Edad.</param>
        /// <param name="numeroCuenta">Número de cuenta.</param>
        public Estudiante(string nombreCompleto, ushort edad, int numeroCuenta)
        {
            NombreCompleto = nombreCompleto;
            Edad = edad;
            NumeroCuenta = numeroCuenta;
        }

        /// <summary>
        /// Imprime un mensaje de que el estudiante está estudiando.
        /// </summary>
        public virtual void Estudia()
        {
            Console.WriteLine($"El estudiante {NombreCompleto} está " +
                "estudiando.");
        }

        /// <summary>
        /// Imprime un mensaje de que el estudiante está haciendo tarea.
        /// </summary>
        public virtual void Tarea()
        {
            Console.WriteLine($"El estudiante {NombreCompleto} hace tarea.");
        }

        /// <summary>
        /// Imprime un mensaje de que el estudiante duerme.
        /// </summary>
        public virtual void Dormir()
        {
            Console.WriteLine($"El estudiante {NombreCompleto} duerme.");
        }
    }
}
