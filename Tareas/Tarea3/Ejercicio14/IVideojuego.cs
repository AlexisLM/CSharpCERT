/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

namespace Ejercicio14
{
    interface IVideojuego
    {
        /// <summary>
        /// Imprime el menú principal.
        /// </summary>
        public void MainMenu();

        /// <summary>
        /// Inicia el juego.
        /// </summary>
        public void Play();

        /// <summary>
        /// Pausa el juego.
        /// </summary>
        public void Pause();

        /// <summary>
        /// Imprime el mensaje de Game Over.
        /// </summary>
        public void GameOver();
    }
}
