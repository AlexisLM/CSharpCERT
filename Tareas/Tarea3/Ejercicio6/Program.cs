using System;

/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Excercise 6.");
            // Creamos cuentas
            Console.WriteLine("Creación de cuentas:");
            CuentaBancaria cuenta1 = new CuentaBancaria("Alan", 5000.0);
            CuentaBancaria cuenta2 = new CuentaBancaria("Brito", 1000.0);

            // Depósitos
            Console.WriteLine("\nDepósitos:");
            cuenta1.Deposito(5000.0); // Saldo: 10,000.0
            cuenta2.Deposito(10000.0); // Saldo: 20,000.0

            // Retiros
            Console.WriteLine("\nRetiros:");
            cuenta1.Retiro(15000.0); // Saldo insuficiente
            cuenta2.Retiro(5000.0); // $15,000.0 restante

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
