using System;

namespace Ejercicio17
{
    class Persona
    {
        /// <summary>Nombre completo de la persona.</summary>
        public string NombreCompleto { get; set; }

        /// <summary>Edad de la persona.</summary>
        public ushort Edad { get; set; }

        /// <summary>
        /// Constructor de una Persona.
        /// </summary>
        /// <param name="nombreCompleto">Nombre completo.</param>
        /// <param name="edad">Edad.</param>
        public Persona(string nombreCompleto, ushort edad)
        {
            NombreCompleto = nombreCompleto;
            Edad = edad;
        }

        /// <summary>
        /// Imprime un mensaje de que la persona está respirando.
        /// </summary>
        public void Respirar()
        {
            Console.WriteLine($"{NombreCompleto} está respirando...");
        }

        /// <summary>
        /// Imprime un mensaje de que la persona está comiendo.
        /// </summary>
        public void Comer()
        {
            Console.WriteLine($"{NombreCompleto} está comiendo...");
        }

        /// <summary>
        /// Imprime un mensaje de que la persona está durmiendo.
        /// </summary>
        public void Dormir()
        {
            Console.WriteLine($"{NombreCompleto} está durmiendo...");
        }

        /// <summary>
        /// Imprime un mensaje de que la persona hace una actividad.
        /// </summary>
        public virtual void HacerActividad()
        {
            Console.WriteLine($"{NombreCompleto} está existiendo...");
        }

        /// <summary>
        /// Retorna la representación en cadena de Persona.
        /// </summary>
        /// <returns>Representación en cadena de Persona.</returns>
        public override string ToString()
        {
            return $"Hola, soy {NombreCompleto} y tengo {Edad} años.";
        }
    }
}
