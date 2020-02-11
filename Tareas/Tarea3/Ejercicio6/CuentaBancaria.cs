using System;

/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

namespace Ejercicio6
{
    class CuentaBancaria
    {
        /// <summary>
        /// Saldo de la cuenta.
        /// </summary>
        public double Saldo { get; set; }
        /// <summary>
        /// Nombre de la cuenta.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Constructor de CuentaBancaria.
        /// </summary>
        /// <param name="nombre">Nombre de la cuenta.</param>
        /// <param name="saldo">Saldo de la cuenta.</param>
        public CuentaBancaria(string nombre, double saldo)
        {
            Nombre = nombre;
            Saldo = saldo;

            MostrarInformacion();
        }

        /// <summary>
        /// Deposita una cantidad a la cuenta bancaria.
        /// </summary>
        /// <param name="deposito">Cantidad a depositar.</param>
        public void Deposito(double deposito)
        {
            if (deposito >= 0)
            {
                Saldo += deposito;
                Console.WriteLine("Depósito realizado exitosamente.");
                MostrarInformacion();
            }
            else
                Console.WriteLine("Sólo es posible depositar una cantidad " +
                    "mayor a $0.");
        }

        /// <summary>
        /// Retira dinero de la cuenta bancaria.
        /// </summary>
        /// <param name="retiro">Cantidad a retirar.</param>
        public void Retiro(double retiro)
        {
            if (Saldo > retiro)
            {
                Saldo -= retiro;
                Console.WriteLine("Retiro realizado exitosamente.");
            }
            else
                Console.WriteLine("El saldo es insuficiente.");
            MostrarInformacion();
        }

        /// <summary>
        /// Imprime el nombre de la cuenta y el saldo actual.
        /// </summary>
        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre de la cuenta: {0}\nSaldo: {1}", Nombre,
                Saldo);
        }
    }
}
