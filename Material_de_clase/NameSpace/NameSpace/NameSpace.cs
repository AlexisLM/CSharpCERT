using System;
using System.Collections.Generic;
using System.Text;

namespace MiNameSpace
{
    class Clase1
    {
        public void Metodo()
        {
            Console.WriteLine("Dentro de MiNameSpace");
        }
    }
}

class uno
{
    public void metodo()
    {
        Console.WriteLine("Hola, ¿Cómo estás?");
    }
}

namespace Namespace
{
    class Program
    {
        static void Main()
        {
            MiNameSpace.Clase1 obj1 = new MiNameSpace.Clase1();
            uno obj2 = new uno();
        }
    }
}
