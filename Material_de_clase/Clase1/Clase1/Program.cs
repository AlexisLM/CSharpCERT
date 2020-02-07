using System;

namespace Clase1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona el_vene = new Persona("El vene", 22);
            Persona sadman = new Persona("Sadman", 22);
            Persona seimiuc = new Persona("Seimiuc", 22);

            // Comparación por referencia
            Console.WriteLine("Referencias el_vene y sadman son iguales?");
            Console.WriteLine(el_vene == sadman);

            Console.WriteLine("Referencias sadman y seimiuc son iguales?");
            Console.WriteLine(sadman == seimiuc);
        }
    }
}
