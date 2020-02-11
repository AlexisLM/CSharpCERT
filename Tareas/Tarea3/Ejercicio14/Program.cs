using System;

/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

/**
 * Las interfaces nos permiten definir comportamiento sin necesidad de
 * implementarlo. Además, la diferencia con clases abstractas es que podemos
 * implementar muchas interfaces.
 * 
 * En este caso, la interfaz IVideojuego especifica los métodos de MainMenu(),
 * Play(), Pause() y GameOver() los cuales son los métodos más comunes en un
 * videojuego.
 */
namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Excercise 14.");
            VideojuegoCarreras carreras = new VideojuegoCarreras("Crash CTR");
            VideojuegoPeleas peleas = new VideojuegoPeleas("Bloody Roar");
            VideojuegoAventuras aventuras = new VideojuegoAventuras("Spyro");

            // Carreras
            carreras.MainMenu();
            Console.WriteLine();
            carreras.Play();
            Console.WriteLine();
            carreras.Pause();
            Console.WriteLine();
            carreras.GameOver();

            // Peleas
            Console.WriteLine();
            peleas.MainMenu();
            Console.WriteLine();
            peleas.Play();
            Console.WriteLine();
            peleas.Pause();
            Console.WriteLine();
            peleas.GameOver();
            
            // Aventuras
            Console.WriteLine();
            aventuras.MainMenu();
            Console.WriteLine();
            aventuras.Play();
            Console.WriteLine();
            aventuras.Pause();
            Console.WriteLine();
            aventuras.GameOver();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
