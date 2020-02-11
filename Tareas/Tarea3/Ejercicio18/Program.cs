using System;
using System.IO;

/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

/*
Para la lectura de archivo podemos utilizar la clase StreamReader, el cual
permite la lectura de archivos de forma sencilla.

Para leer una línea simplemente utilizamos sr.ReadLine(), donde sr es una
instancia de StreamReader. En caso de que ya no hayan más líneas por leer,
ReadLine devolverá null.
*/
namespace Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Excercise 18.");
            string file; // Archivo a leer
            string line; // Linea a leer

            Console.Write("Ingrese el nombre de archivo a desplegar su " +
                "contenido: ");
            file = Console.ReadLine();

            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    while ((line = sr.ReadLine()) != null)
                        Console.WriteLine(line);
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"No fue posible leer el archivo {file}.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
