using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        private static readonly string[] colors = { "Magenta", "" };
        private static readonly string[] removeColors = { };
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            foreach(var color in colors)
            {
                list.Add(color);
            }

            List<string> removeList = new List<string>(removeColors);
            MostrarLista(list);

            Console.ReadKey();
        }

        private static void MostrarLista(List<string> list)
        {
            foreach(string str in list)
            {
                Console.Write(str);
            }
        }
    }
}
