/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

namespace Ejercicio13
{
    class CarroVW : Carro
    {
        /// <summary>Modelo del carro.</summary>
        public string Modelo { get; set; }

        /// <summary>
        /// Constructor de un CarroVW.
        /// </summary>
        /// <param name="peso">Peso del carro.</param>
        /// <param name="altura">Altura del carro.</param>
        /// <param name="modelo">Modelo del carro.</param>
        public CarroVW(double peso, double altura, string modelo) : base(peso,
            altura)
        {
            Modelo = modelo;
        }

        /// <summary>
        /// Retorna la representación en cadena del carro.
        /// </summary>
        /// <returns>Representación en cadena del carro.</returns>
        public override string ToString()
        {
            return $"El modelo es: {Modelo}.\nEl peso es: {Peso:N0}.\n" +
                $"La altura es: {Altura:F2}.";
        }
    }
}
