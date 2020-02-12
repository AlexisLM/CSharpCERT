using System;

namespace Excepciones2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingresa un valor para calcular s raiz cuadrada: ");
                double dato = Convert.ToDouble(Console.ReadLine());
                double resultado = RaizCuadrada(dato);

                Console.WriteLine("La raiz cuadrada de {0} es {1}", dato,
                    resultado);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("\n{0}", fe.Message);
                Console.WriteLine("Debes ingresar un número.");
            }
            catch (NegativeNumberException nne)
            {
                Console.WriteLine("\n{0}", nne.Message);
                Console.WriteLine("Debes ingresar un número no negativo.");
            }
        }

        static double RaizCuadrada(double num)
        {
            if (num < 0)
                throw new NegativeNumberException();
            return Math.Sqrt(num);
        }
    }
}
