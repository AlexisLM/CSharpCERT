using System;

/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

namespace Ejercicio7
{
    class NumeroComplejo
    {
        /// <summary>
        /// Parte real del número complejo.
        /// </summary>
        public double ParteReal { get; set; }
        /// <summary>
        /// Parte imaginaria del número complejo.
        /// </summary>
        public double ParteImaginaria { get; set; }

        /// <summary>
        /// Constructor de un NumeroComplejo.
        /// </summary>
        /// <param name="parteReal">Parte real.</param>
        /// <param name="parteImaginaria">Parte imaginaria.</param>
        public NumeroComplejo(double parteReal, double parteImaginaria)
        {
            ParteReal = parteReal;
            ParteImaginaria = parteImaginaria;
        }

        /// <summary>
        /// Imprime el número complejo con formato a + bi.
        /// </summary>
        public void Imprimir()
        {
            Console.WriteLine($"{ParteReal} + {ParteImaginaria}i");
        }

        /// <summary>
        /// Crea un número complejo a partir de la suma de
        /// <paramref name="c1"/> con <paramref name="c2"/>.
        /// </summary>
        /// <param name="c1">Primer sumando.</param>
        /// <param name="c2">Segundo sumando.</param>
        /// <returns>Número complejo resultante.</returns>
        public static NumeroComplejo Suma(NumeroComplejo c1, NumeroComplejo c2)
        {
            return new NumeroComplejo(c1.ParteReal + c2.ParteReal,
                c1.ParteImaginaria + c2.ParteImaginaria);
        }
    }
}
