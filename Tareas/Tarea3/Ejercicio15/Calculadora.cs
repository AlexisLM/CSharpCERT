using System;

/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

namespace Ejercicio15
{
    static class Calculadora
    {
        /// <summary>
        /// Ejecuta una operación.
        /// </summary>
        /// <param name="operation">
        /// 1: Suma, 2: Resta, 3: Multiplicación, 4: División.
        /// </param>
        private static void ExecOperation(ushort operation)
        {
            double n1 = GetDoubleFromSTDIN("Ingresa primer número: ");
            double n2 = GetDoubleFromSTDIN("Ingresa segundo número: ");

            double result = operation == 1 ? n1 + n2 : operation == 2 ? 
                n1 - n2 : operation == 3 ? n1 * n2 : n1 / n2;
            string oper = operation == 1 ? "+" : operation == 2 ? "-" :
                operation == 3 ? "*" : "/";

            Console.WriteLine($"--------------\n{n1} {oper} {n2} = {result}");
        }

        /// <summary>
        /// Imprime el menú con las opciones.
        /// </summary>
        private static void PrintMenu()
        {
            Console.Write("\nSeleccione una de las siguientes opciones:" +
                "\n1] Suma.\n2] Resta.\n3] Multiplicación.\n4] División.\n" +
                "5] Salir.\n---------------------\nOpción: ");
        }

        /// <summary>
        /// Imprime <paramref name="msg"/> a la salida estándar y obtiene la
        /// entrada del usuario.
        /// </summary>
        /// <param name="msg">Mensaje a imprimir.</param>
        /// <returns>Entrada del usuario.</returns>
        private static double GetDoubleFromSTDIN(string msg)
        {
            Console.Write(msg);
            return Convert.ToDouble(Console.ReadLine()); ;
        }

        public static void Run()
        {
            string opcion;  // Opción seleccionada
            try
            {
                do // Realizar operación
                {
                    PrintMenu();
                    opcion = Console.ReadLine();
                    if (opcion.Equals("1"))
                        ExecOperation(1);
                    else if (opcion.Equals("2"))
                        ExecOperation(2);
                    else if (opcion.Equals("3"))
                        ExecOperation(3);
                    else if (opcion.Equals("4"))
                        ExecOperation(4);
                } while (!opcion.Equals("5"));
            }
            catch (FormatException)
            {
                Console.WriteLine("Debes ingresar un número.");
                Run();
            }
            catch (OverflowException)
            {
                Console.WriteLine("El número ingresado o el resultado es muy" +
                    "grande. Intente con un valor más pequeño.");
                Run();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No puedes dividir entre cero.");
                Run();
            }
        }
    }
}
