using System;
using System.Linq;
using System.Collections.Generic;

namespace QuerySintaxis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 2, 9, 5, 0, 3, 7, 4, 8, 5 };
            Console.WriteLine("Arreglo original:");
            Imprime(numeros);

            // Query obtiene los números mayores a 4
            var filtered = from n in numeros where n > 4 select n;

            Console.WriteLine("Arreglo filtrado:");
            Imprime(filtered);

            // Ordenar el arreglo
            var sorted = from n in numeros orderby n select n;
            Console.WriteLine("Arreglo ordenado:");
            Imprime(sorted);

            // Ordenar el arreglo descendentemente
            var sortedDesc = from n in numeros orderby n descending select n;
            Console.WriteLine("Arreglo ordenado descendentemente:");
            Imprime(sortedDesc);

            // Filtrados ordenados
            var sortedFiltered = from n in filtered orderby n select n;
            Console.WriteLine("Arreglo filtrado ordenado:");
            Imprime(sortedFiltered);

            // ----------

            string[] paises = { "México", "Rusia", "Austria", "Cuba", "Canadá",
                "Alemania", "Perú" };

            // Paises cuyo nombre contiene a, ordenados por longitud.
            IEnumerable<string> query = from p in paises where p.Contains("a")
                                        orderby p.Length select p.ToUpper();
            Console.WriteLine("Paises que contienen 'a':");
            Imprime(query);

            // Paises cuya longitud de nombre sea mayor a 5;
            query = from p in paises where p.Length > 5 orderby p select p;
            Console.WriteLine("Paises cuya longitud de nombre es mayor a 5:");
            Imprime(query);

            // Las iniciales de los paises
            IEnumerable<char> query3 = from p in paises orderby p.Length
                                       select p[0];
            Console.WriteLine("Iniciales de los paises:");
            Imprime(query3);

            Console.ReadKey();
        }

        static void Imprime<T>(IEnumerable<T> arreglo)
        {
            foreach (var elemento in arreglo)
                Console.Write($" {elemento} ");
            Console.WriteLine();
        }
    }
}
