using System;
using System.Collections.Generic;
using System.Text;

namespace NameSpace
{
    class Program
    {
        static void Main()
        {
            int[] list = { 34, 72, 16, 44, 25, 30, 10 };
            int[] temp = new int[list.Length];

            // Genera una copia del arreglo original
            Array.Copy(list, temp, list.Length);
            Console.WriteLine("Arreglo Original: ");
            MostrarArreglo(list);

            // Invierte el arreglo
            Array.Reverse(temp);
            Console.WriteLine("Arreglo Invertido: ");
            MostrarArreglo(temp);

            // Ordena el arreglo
            Array.Sort(list);
            Console.Write("Arreglo ordenado: ");
            MostrarArreglo(list);

            Console.WriteLine("Indice del número 44: " + Array.IndexOf(temp, 44));
            Console.ReadKey();
        }

        static void MostrarArreglo(int[] arreglo)
        {
            foreach (int num in arreglo)
            {
                Console.WriteLine("{0} ", num);
            }
            Console.WriteLine();
        }

    }
}
