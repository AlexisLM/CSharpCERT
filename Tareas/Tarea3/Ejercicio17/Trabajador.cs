using System;

namespace Ejercicio17
{
    class Trabajador : Persona
    {
        /// <summary>RFC del trabajador.</summary>
        public string RFC { get; set; } 

        /// <summary>
        /// Constructor de un Estudiante.
        /// </summary>
        /// <param name="nombreCompleto">Nombre completo.</param>
        /// <param name="edad">Edad.</param>
        /// <param name="rfc">RFC.</param>
        public Trabajador(string nombreCompleto, ushort edad, string rfc)
            : base(nombreCompleto, edad)
        {
            RFC = rfc;
        }

        /// <summary>
        /// Imprime un mensaje de que el estudiante está estudiando.
        /// </summary>
        public override void HacerActividad()
        {
            Console.WriteLine($"El trabajador {NombreCompleto} está " +
                "trabajando.");
        }

        /// <summary>
        /// Retorna la representación en cadena de Trabajador.
        /// </summary>
        /// <returns>Representación en cadena de Trabajador.</returns>
        public override string ToString()
        {
            return $"Hola, soy {NombreCompleto}, tengo {Edad} años y soy " +
                $"trabajador.";
        }
    }
}
