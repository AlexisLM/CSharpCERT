using System;

namespace Cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Concatenación de cadenas
            Console.WriteLine("Hola " + "Mundo");
            Console.WriteLine(string.Concat("Hola ", "Mundo"));

            string cadena = "Esta es una cadena de prueba";

            Console.WriteLine(cadena);
            Console.WriteLine("Tamaño: {0}", cadena.Length);
            Console.WriteLine("Mayúsculas: {0}", cadena.ToUpper());
            Console.WriteLine("Minúsculas: {0}", cadena.ToLower());

            Console.WriteLine("Replace: {0}", cadena.Replace(" ", ""));
            Console.WriteLine("Caracter en índice 0: {0}", cadena[0]);

            Console.WriteLine("Substrings: {0}", cadena.Substring(1, 8));
            Console.WriteLine("Cadena contiene \"es\"? {0}",
                cadena.Contains("es"));

            // Formato de cadenas
            int naranjas = 8;
            int platanos = 2;
            int manzanas = 6;

            string ejemplo = string.Format("Hay {0} plátanos, {1} narajnjas," +
                " {2} manzanas", platanos, naranjas, manzanas);
            Console.WriteLine(ejemplo);

            // Ajuste de decimales
            Console.WriteLine("PI: {0:0.00}", Math.PI);

        }
    }
}
