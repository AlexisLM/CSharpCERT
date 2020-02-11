using System;

/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

namespace Ejercicio9
{
    class Circulo
    {
        /// <summary>
        /// Radio del círculo.
        /// </summary>
        public double Radio { get; set; }

        /// <summary>
        /// Constructor de un Circulo.
        /// </summary>
        /// <param name="radio">Radio del círculo.</param>
        public Circulo(double radio)
        {
            Radio = radio;
        }

        /// <summary>
        /// Obtiene el diámetro del círculo.
        /// </summary>
        /// <returns>Diámetro del círculo.</returns>
        public double Diametro()
        {
            return 2 * Radio;
        }

        /// <summary>
        /// Obtiene el perímetro del círculo.
        /// </summary>
        /// <returns>Perímetro del círculo.</returns>
        public double Perimetro()
        {
            return Math.PI * Diametro();
        }

        /// <summary>
        /// Obtiene el área del círculo.
        /// </summary>
        /// <returns>Área del círculo.</returns>
        public double Area()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        /// <summary>
        /// Retorna un nuevo círculo a partir de truncar el radio del círculo.
        /// </summary>
        /// <returns>Circulo con radio truncado.</returns>
        public Circulo TruncarCirculo()
        {
            return new Circulo(Math.Truncate(Radio));
        }

        /// <summary>
        /// Retorna un nuevo círculo a partir de redondear el radio del
        /// círculo.
        /// </summary>
        /// <returns>Circulo con radio redondeado.</returns>
        public Circulo RedondearCirculo()
        {
            return new Circulo(Math.Round(Radio));
        }

        /// <summary>
        /// Retorna la representación en cadena del círculo.
        /// </summary>
        /// <returns>Reprensentación en cadena del objeto.</returns>
        public override string ToString()
        {
            return $"Radio: {Radio}";
        }

    }
}
