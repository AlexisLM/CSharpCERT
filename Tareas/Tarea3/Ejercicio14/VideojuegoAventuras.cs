using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio14
{
    class VideojuegoAventuras
    {
        public string Nombre { get; set; }

        public VideojuegoAventuras(string nombre)
        {
            Nombre = nombre;
        }

        /// <summary>
        /// Imprime el menú principal.
        /// </summary>
        public void MainMenu()
        {
            Console.WriteLine($":::::::: {Nombre} ::::::::");
            Console.WriteLine("> Continuar aventura <");
            Console.WriteLine("  Nueva aventura  ");
            Console.WriteLine("  Configuraciones  ");
            Console.WriteLine("  Créditos  ");
        }

        /// <summary>
        /// Inicia el juego.
        /// </summary>
        public void Play()
        {
            Console.WriteLine("~ Nivel 12 ~");
        }

        /// <summary>
        /// Pausa el juego.
        /// </summary>
        public void Pause()
        {
            Console.WriteLine("Juego pausado");
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
