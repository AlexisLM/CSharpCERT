using System;

/**
 * Tarea 2.
 * Autor: Alexis Brayan López Matías.
 */

namespace Tarea2
{
    /// <summary>
    /// Clase que representa a un Alumno.
    /// </summary>
    class Alumno
    {
        /// <summary>
        /// Nombre del alumno.
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// Apellido paterno.
        /// </summary>
        public string ApPaterno { get; set; }
        /// <summary>
        /// Apellido materno.
        /// </summary>
        public string ApMaterno { get; set; }

        /// <summary>
        /// Calificación de proyecto.
        /// </summary>
        public int CalProyecto { get; set; }
        /// <summary>
        /// Cantidad de tareas.
        /// </summary>
        public int CantTareas { get; set; }
        /// <summary>
        /// Cantidad de participaciones.
        /// </summary>
        public int CantParticipaciones { get; set; }

        /// <summary>
        /// Constructor de un Alumno.
        /// </summary>
        /// <param name="nombre">Nombre del alumno.</param>
        /// <param name="apPaterno">Apellido paterno.</param>
        /// <param name="apMaterno">Apellido materno.</param>
        /// <param name="calProyecto">Calificación del proyecto.</param>
        /// <param name="cantTareas">Cantidad de tareas realizadas.</param>
        /// <param name="cantParticipaciones">
        /// Cantidad de participaciones.
        /// </param>
        public Alumno(string nombre, string apPaterno, string apMaterno,
            int calProyecto, int cantTareas, int cantParticipaciones)
        {
            Nombre = nombre;
            ApPaterno = apPaterno;
            ApMaterno = apMaterno;
            CalProyecto = calProyecto;
            CantTareas = cantTareas;
            CantParticipaciones = cantParticipaciones;
        }

        /// <summary>
        /// Retorna el nombre completo de un alumno.
        /// </summary>
        /// <returns>Nombre completo del alumno.</returns>
        public string GetNombreCompleto()
        {
            return Nombre + " " + ApPaterno + " " + ApMaterno;
        }

    }

    /// <summary>
    /// Clase estática que permite calificar a un grupo de alumnos.
    /// </summary>
    static class Calculadora
    {
        /// <summary>
        /// Califica a un grupo de alumnos solicitados al usuario.
        /// </summary>
        public static void CalificaAlumnos()
        {
            int cant_alumnos; // Cantidad de alumnos a calificar
            Alumno[] alumnos; // Arreglo de alumnos a calificar
            int index; // Indice para iteraciones

            // Datos de alumno
            string nombre, ap_paterno, ap_materno;
            int cal_proyecto, cant_tareas, cant_participaciones;

            // Obtenemos cantidad de alumnos a calificar
            cant_alumnos = GetValidPositiveInt(0, int.MaxValue,
                "Ingrese la cantidad de alumnos a calificar: ");
            alumnos = new Alumno[cant_alumnos];

            // Obtenemos datos
            for(index = 0; index < alumnos.Length; index++)
            {
                Console.WriteLine("Datos del alumno {0}", index + 1);
                nombre = GetValidString("Ingrese el nombre del alumno: ");
                ap_paterno = GetValidString("Ingrese el apellido paterno del" +
                    " alumno: ");
                ap_materno = GetValidString("Ingrese el apellido materno del" +
                    " alumno: ");
                cal_proyecto = GetValidPositiveInt(0, 10, "Ingrese la " +
                    "calificación del proyecto: ");
                cant_tareas = GetValidPositiveInt(0, 5, "Ingrese " +
                    "la cantidad de tareas realizadas: ");
                cant_participaciones = GetValidPositiveInt(0, int.MaxValue,
                    "Ingrese la cantidad de participaciones: ");
                Console.WriteLine();

                alumnos[index] = new Alumno(nombre, ap_paterno, ap_materno,
                    cal_proyecto, cant_tareas, cant_participaciones);
            }

            // Obtenemos calificaciones
            Console.WriteLine("Las calificaciones son las siguientes:");
            for(index = 0; index < alumnos.Length; index++)
                Console.WriteLine("La calificación final de {0} es de " +
                    "{1}/100", alumnos[index].GetNombreCompleto(),
                    CalificaAlumno(alumnos[index]));
        }

        /// <summary>
        /// Califica a un alumno y retorna dicha calificación.
        /// </summary>
        /// <param name="alumno">Alumno a calificar.</param>
        /// <returns>Calificación del alumno entre 50 y 100.</returns>
        private static int CalificaAlumno(Alumno alumno)
        {
            int cal = (alumno.CalProyecto * 6) + (alumno.CantTareas * 8) +
                (alumno.CantParticipaciones > 5 ? 8 : 0);
            return cal < 50 ? 50 : (cal > 100 ? 100 : cal);
        }

        /// <summary>
        /// Obtiene un entero válido en un rango ingresado por el usuario.
        /// </summary>
        /// <param name="lower_boud">Limite inferior.</param>
        /// <param name="upper_bound">Limite superior.</param>
        /// <param name="msg">Mensaje a imprimir al solicitar el valor.</param>
        /// <returns>Entero válido en el rango.</returns>
        private static int GetValidPositiveInt(int lower_boud, int upper_bound,
            string msg)
        {
            int number = lower_boud - 1; // Valor inicial
            string input;  // Entrada del usuario
            // Pedimos una cantidad válida
            while (number < lower_boud || number > upper_bound)
            {
                Console.Write(msg);
                input = Console.ReadLine();
                if (!Int32.TryParse(input, out number))
                    number = lower_boud - 1;
                number = number >= lower_boud && number <= upper_bound ?
                         number : lower_boud - 1;
            }
            return number;
        }

        /// <summary>
        /// Obtiene una cadena válida ingresada por el usuario.
        /// </summary>
        /// <param name="msg">
        /// Mensaje a imprimir al solicitar la cadena.
        /// </param>
        /// <returns>Cadena válida. (No vacía)</returns>
        private static string GetValidString(string msg)
        {
            string str = ""; // Valor inicial
            while (string.Equals(str, "")) // Pedimos una entrada válida
            {
                Console.Write(msg);
                str = Console.ReadLine();
            }
            return str;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculadora.CalificaAlumnos();
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
