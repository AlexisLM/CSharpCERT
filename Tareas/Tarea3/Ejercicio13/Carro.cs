using System;

/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

namespace Ejercicio13
{
    class Carro
    {
        /// <summary>Peso del carro.</summary>
        public double Peso { get; set; }

        /// <summary>Altura del carro.</summary>
        public double Altura { get; set; }

        /// <summary>
        /// Estado del carro. (True: Encendido, False: Apagado)
        /// </summary>
        public bool Encendido { get; set; }

        /// <summary>
        /// Constructor de un Carro.
        /// </summary>
        /// <param name="peso">Peso del carro.</param>
        /// <param name="altura">Altura del carro.</param>
        public Carro(double peso, double altura)
        {
            Peso = peso;
            Altura = altura;
        }

        /// <summary>
        /// Enciende el carro.
        /// </summary>
        public void Encender()
        {
            Encendido = true;
            Console.WriteLine("El carro está encendido.");
        }

        /// <summary>
        /// Apaga el carro.
        /// </summary>
        public void Apagar()
        {
            Encendido = false;
            Console.WriteLine("El carro está apagado.");
        }

        /// <summary>
        /// Retorna el estado del carro. True: Encendido, False: Apagado.
        /// </summary>
        /// <returns></returns>
        public bool Estado()
        {
            return Encendido;
        }

        /// <summary>
        /// Retorna la representación en cadena del carro.
        /// </summary>
        /// <returns>Representación en cadena del carro.</returns>
        public override string ToString()
        {
            return $"El peso es: {Peso:N0}.\nLa altura es: {Altura:F2}.";
        }
    }
}
