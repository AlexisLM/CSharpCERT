using System;

/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

namespace Ejercicio9
{
    class Rectangulo
    {
        /// <summary>
        /// Base del rectángulo.
        /// </summary>
        public double Base { get; set; }

        /// <summary>
        /// Altura del rectángulo.
        /// </summary>
        public double Altura { get; set; }

        /// <summary>
        /// Constructor de un Rectangulo.
        /// </summary>
        /// <param name="base_">Base del rectángulo.</param>
        /// <param name="altura">Altura del rectángulo.</param>
        public Rectangulo(double base_, double altura)
        {
            Base = base_;
            Altura = altura;
        }

        /// <summary>
        /// Obtiene el perímetro del rectángulo.
        /// </summary>
        /// <returns>Perímetro del rectángulo.</returns>
        public double Perimetro()
        {
            return (Base * 2) + (Altura * 2);
        }

        /// <summary>
        /// Obtiene el área del rectángulo.
        /// </summary>
        /// <returns>Área del rectángulo.</returns>
        public double Area()
        {
            return Base * Altura;
        }

        /// <summary>
        /// Obtiene la longitud de la diagonal del rectángulo.
        /// </summary>
        /// <returns>Longitud de la diagonal del rectángulo.</returns>
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Altura, 2));
        }

        /// <summary>
        /// Retorna un nuevo rectángulo a partir de truncar la base y altura
        /// del rectángulo.
        /// </summary>
        /// <returns>Rectangulo con base y altura truncada.</returns>
        public Rectangulo TruncarRectangulo()
        {
            return new Rectangulo(Math.Truncate(Base), Math.Truncate(Altura));
        }

        /// <summary>
        /// Retorna un nuevo rectángulo a partir de redondear la base y altura
        /// del rectángulo.
        /// </summary>
        /// <returns>Rectangulo con base y altura redondeada.</returns>
        public Rectangulo RedondearRectangulo()
        {
            return new Rectangulo(Math.Round(Base), Math.Round(Altura));
        }

        /// <summary>
        /// Retorna la representación en cadena del rectángulo.
        /// </summary>
        /// <returns>Representación en cadena del objeto.</returns>
        public override string ToString()
        {
            return $"Base: {Base}, Altura: {Altura}.";
        }

    }
}
