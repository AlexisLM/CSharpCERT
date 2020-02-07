using System;
using System.Collections.Generic;
using System.Text;

namespace NameSpace
{
    class Program 
    {
        static void Main()
        {
            var anonimo = new
            {
                Modelo = "Bocho",
                Precio = 80000,
                Placas = "45RT65"
            };

            Console.WriteLine("Datos del objeto anónimo");
            Console.WriteLine(anonimo.Modelo);
            Console.WriteLine(anonimo.Precio);
            Console.WriteLine(anonimo.Placas);
        }
    }
}
