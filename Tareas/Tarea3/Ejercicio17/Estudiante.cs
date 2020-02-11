using System;

/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

namespace Ejercicio17
{
    class Estudiante : Persona
    {
        /// <summary>Número de cuenta del estudiante.</summary>
        public int NumeroCuenta { get; set; }

        /// <summary>
        /// Constructor de un Estudiante.
        /// </summary>
        /// <param name="nombreCompleto">Nombre completo.</param>
        /// <param name="edad">Edad.</param>
        /// <param name="numeroCuenta">Número de cuenta.</param>
        public Estudiante(string nombreCompleto, ushort edad, int numeroCuenta)
            : base(nombreCompleto, edad)
        {
            NumeroCuenta = numeroCuenta;
        }

        /// <summary>
        /// Imprime un mensaje de que el estudiante está estudiando.
        /// </summary>
        public override void HacerActividad()
        {
            Console.WriteLine($"El estudiante {NombreCompleto} está " +
                "estudiando.");
        }

        /// <summary>
        /// Retorna la representación en cadena de Estudiante.
        /// </summary>
        /// <returns>Representación en cadena de Estudiante.</returns>
        public override string ToString()
        {
            return $"Hola, soy {NombreCompleto}, tengo {Edad} años y soy " +
                $"estudiante.";
        }
    }
}

