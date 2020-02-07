using System;

namespace Clase1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("El vene");

            Console.WriteLine(c1.Nombre);
            Console.WriteLine(c1.Edad);
            Console.WriteLine(c1.Cuenta);

            Console.WriteLine(Cliente.mensaje());
            Console.WriteLine(c1.Dinero);
            c1.Depositar(5000);
            Console.WriteLine(c1.Dinero);
        }
    }
}
