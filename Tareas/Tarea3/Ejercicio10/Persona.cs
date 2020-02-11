using System;

/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

namespace Ejercicio10
{
    class Persona
    {
        public string Nombre { get; set; }
        public ushort Edad { get; set; }
        public double Estatura { get; set; }
        public double Peso { get; set; }

        /// <summary>
        /// Constructor de Persona.
        /// </summary>
        /// <param name="nombre">Nombre de la persona.</param>
        /// <param name="edad">Edad de la persona.</param>
        /// <param name="estatura">Estatura de la persona.</param>
        /// <param name="peso">Peso de la persona.</param>
        public Persona(string nombre, ushort edad, double estatura,
            double peso)
        {
            Nombre = nombre;
            Edad = edad;
            Estatura = estatura;
            Peso = peso;
        }

        /// <summary>
        /// Imprime un saludo.
        /// </summary>
        public void Saludar()
        {
            Console.WriteLine($"Hola, mi nombre es {Nombre}.");
        }

        /// <summary>
        /// Imprime un mensaje al dormir.
        /// </summary>
        public void Dormir()
        {
            Console.WriteLine($"{Nombre} está durmiendo... ZzZz...");
        }

        /// <summary>
        /// Imprime un mensaje al despertar.
        /// </summary>
        public void Despertar()
        {
            Console.WriteLine("Bueeeeenos días alegriiiiiia... XD");
        }

        /// <summary>
        /// Retorna la representación en cadena del objeto.
        /// </summary>
        /// <returns>Representación en cadena del objeto.</returns>
        public override string ToString()
        {
            return $"Nombre: {Nombre}, Edad: {Edad} años, " +
                $"Estatura: {Estatura}m, Peso: {Peso}kg.";
        }

    }
}
