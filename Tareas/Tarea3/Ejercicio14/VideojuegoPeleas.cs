using System;

/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

namespace Ejercicio14
{
    class VideojuegoPeleas
    {
        public string Nombre { get; set; }

        public VideojuegoPeleas(string nombre)
        {
            Nombre = nombre;
        }

        /// <summary>
        /// Imprime el menú principal.
        /// </summary>
        public void MainMenu()
        {
            Console.WriteLine($":::::::: {Nombre} ::::::::");
            Console.WriteLine("> 1vs1 <");
            Console.WriteLine("  Multiplayer  ");
            Console.WriteLine("  Settings  ");
            Console.WriteLine("  Credits  ");
        }

        /// <summary>
        /// Inicia el juego.
        /// </summary>
        public void Play()
        {
            Console.WriteLine("Ready...");
            Console.WriteLine("Fight!");
        }

        /// <summary>
        /// Pausa el juego.
        /// </summary>
        public void Pause()
        {
            Console.WriteLine("Game Paused...");
        }

        /// <summary>
        /// Imprime el mensaje de Game Over.
        /// </summary>
        public void GameOver()
        {
            Console.WriteLine("You lose!");
        }
    }
}
