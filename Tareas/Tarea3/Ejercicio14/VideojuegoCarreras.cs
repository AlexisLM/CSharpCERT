using System;

/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

namespace Ejercicio14
{
    class VideojuegoCarreras : IVideojuego
    {
        public string Nombre { get; set; }
        
        public VideojuegoCarreras(string nombre)
        {
            Nombre = nombre;
        }

        /// <summary>
        /// Imprime el menú principal.
        /// </summary>
        public void MainMenu()
        {
            Console.WriteLine($":::::::: {Nombre} ::::::::");
            Console.WriteLine("> Iniciar carrera <");
            Console.WriteLine("  Configuraciones  ");
            Console.WriteLine("  Créditos  ");
        }

        /// <summary>
        /// Inicia el juego.
        /// </summary>
        public void Play()
        {
            Console.WriteLine("Comenzando carrera en...");
            Console.WriteLine("\t3...");
            Console.WriteLine("\t2...");
            Console.WriteLine("\t1...");
        }

        /// <summary>
        /// Pausa el juego.
        /// </summary>
        public void Pause()
        {
            Console.WriteLine("Juego en pausa...");
        }

        /// <summary>
        /// Imprime el mensaje de Game Over.
        /// </summary>
        public void GameOver()
        {
            Console.WriteLine("Fin del juego");
        }
    }
}
