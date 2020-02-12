using System;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingresa el numerador: ");
                int numerador = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresa el denominador: ");
                int denominador = Convert.ToInt32(Console.ReadLine());

                // La división genera DivideByZeroException
                double resultado = numerador / denominador;

                Console.WriteLine("\nResultado: {0} / {1} = {2}", numerador,
                    denominador, resultado);
            }
            catch (FormatException formatE)
            {
                Console.WriteLine("\n{0}", formatE.Message);
                Console.WriteLine("Debes ingresar números enteros.");
            }
            catch (DivideByZeroException divideBZE)
            {
                Console.WriteLine("\n{0}", divideBZE.Message);
                Console.WriteLine("El denominador no puede ser cero.");
            }
            finally
            {
                Console.WriteLine("Fin del programa");
            }

            Console.ReadKey();
        }
    }
}
