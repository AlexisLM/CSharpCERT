using System;

/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

/*
Investigación:

Abs(Decimal)
Devuelve el valor absoluto de un número decimal.

Abs(Double)
Devuelve el valor absoluto de un número de coma flotante de doble precisión.

Abs(Int16)
Devuelve el valor absoluto de un entero con signo de 16 bits.

Abs(Int32)
Devuelve el valor absoluto de un entero con signo de 32 bits.

Abs(Int64)
Devuelve el valor absoluto de un entero con signo de 64 bits.

Abs(SByte)
Devuelve el valor absoluto de un entero con signo de 8 bits.

Abs(Single)
Devuelve el valor absoluto de un número de coma flotante de precisión simple.

Acos(Double)
Devuelve el ángulo cuyo coseno es el número especificado.

Asin(Double)
Devuelve el ángulo cuyo seno es el número especificado.

Atan(Double)
Devuelve el ángulo cuya tangente es el número especificado.

Atan2(Double, Double)
Devuelve el ángulo cuya tangente es el cociente de dos números especificados.

BigMul(Int32, Int32)
Produce el producto completo de dos números de 32 bits.

Ceiling(Decimal)
Devuelve el valor entero más pequeño que es mayor o igual que el número
decimal especificado.

Ceiling(Double)
Devuelve el valor entero más pequeño que es mayor o igual que el número de
punto flotante de precisión doble especificado.

Cos(Double)
Devuelve el coseno del ángulo especificado.

Cosh(Double)
Devuelve el coseno hiperbólico del ángulo especificado.

DivRem(Int32, Int32, Int32)
Calcula el cociente de dos enteros con signo de 32 bits y también devuelve el
resto en un parámetro de salida.

DivRem(Int64, Int64, Int64)
Calcula el cociente de dos enteros con signo de 64 bits y también devuelve el
resto en un parámetro de salida.

Exp(Double)
Devuelve e elevado a la potencia especificada.

Floor(Decimal)
Devuelve el valor entero más grande menor o igual que el número decimal
especificado.

Floor(Double)
Devuelve el valor entero más grande menor o igual que el número de punto
flotante de precisión doble especificado.

IEEERemainder(Double, Double)
Devuelve el resto resultante de la división de un número especificado por otro
número especificado.

Log(Double)
Devuelve el logaritmo natural (base e) de un número especificado.
Log(Double, Double)
Devuelve el logaritmo de un número especificado en una base específica.

Log10(Double)
Devuelve el logaritmo de base 10 de un número especificado.

Max(Byte, Byte)
Devuelve el mayor de dos enteros sin signo de 8 bits.

Max(Decimal, Decimal)
Devuelve el mayor de dos números decimales.

Max(Double, Double)
Devuelve el mayor de dos números de punto flotante de doble precisión.

Max(Int16, Int16)
Devuelve el mayor de dos enteros con signo de 16 bits.

Max(Int32, Int32)
Devuelve el mayor de dos enteros con signo de 32 bits.

Max(Int64, Int64)
Devuelve el mayor de dos enteros con signo de 64 bits.

Max(SByte, SByte)
Devuelve el mayor de dos enteros con signo de 8 bits.

Max(Single, Single)
Devuelve el mayor de dos números de punto flotante de precisión simple.

Max(UInt16, UInt16)
Devuelve el mayor de dos enteros sin signo de 16 bits.

Max(UInt32, UInt32)
Devuelve el mayor de dos enteros sin signo de 32 bits.

Max(UInt64, UInt64)
Devuelve el mayor de dos enteros sin signo de 64 bits.

Min(Byte, Byte)
Devuelve el menor de dos enteros sin signo de 8 bits.

Min(Decimal, Decimal)
Devuelve el menor de dos números decimales.

Min(Double, Double)
Devuelve el menor de dos números de punto flotante de doble precisión.

Min(Int16, Int16)
Devuelve el menor de dos enteros con signo de 16 bits.

Min(Int32, Int32)
Devuelve el menor de dos enteros con signo de 32 bits.

Min(Int64, Int64)
Devuelve el menor de dos enteros con signo de 64 bits.

Min(SByte, SByte)
Devuelve el menor de dos enteros con signo de 8 bits.

Min(Single, Single)
Devuelve el menor de dos números de punto flotante de precisión simple.

Min(UInt16, UInt16)
Devuelve el menor de dos enteros sin signo de 16 bits.

Min(UInt32, UInt32)
Devuelve el menor de dos enteros sin signo de 32 bits.

Min(UInt64, UInt64)
Devuelve el menor de dos enteros sin signo de 64 bits.

Pow(Double, Double)
Devuelve un número especificado elevado a la potencia especificada.

Round(Decimal)
Redondea un valor decimal al valor entero más cercano y redondea los valores
del punto medio al número par más cercano.

Round(Decimal, Int32)
Redondea un valor decimal a un número específico de dígitos fraccionarios y
redondea los valores del punto medio al número par más cercano.

Round(Decimal, Int32, MidpointRounding)
Redondea un valor decimal a un número específico de dígitos fraccionarios y
utiliza la convención de redondeo especificada para valores de punto medio.

Round(Decimal, MidpointRounding)
Redondea un valor decimal al entero más cercano y utiliza la convención de
redondeo especificada para valores de punto medio.

Round(Double)
Redondea un valor de coma flotante de doble precisión al valor entero más
cercano y redondea los valores de punto medio al número par más cercano.

Round(Double, Int32)
Redondea un valor de coma flotante de doble precisión a un número específico de
dígitos fraccionarios, y redondea los valores de punto medio al número par más
cercano.

Round(Double, Int32, MidpointRounding)
Redondea un valor de coma flotante de doble precisión a un número específico de
dígitos fraccionarios, y utiliza la convención de redondeo especificada para
valores de punto medio.

Round(Double, MidpointRounding)
Redondea un valor de coma flotante de doble precisión al entero más cercano y
utiliza la convención de redondeo especificada para valores de punto medio.

Sign(Decimal)
Devuelve un número entero que indica el signo de un número decimal.

Sign(Double)
Devuelve un número entero que indica el signo de un número de coma flotante de
doble precisión.

Sign(Int16)
Devuelve un entero que indica el signo de un entero con signo de 16 bits.

Sign(Int32)
Devuelve un entero que indica el signo de un entero con signo de 32 bits.

Sign(Int64)
Devuelve un entero que indica el signo de un entero con signo de 64 bits.

Sign(SByte)
Devuelve un entero que indica el signo de un entero con signo de 8 bits.

Sign(Single)
Devuelve un número entero que indica el signo de un número de coma flotante de
precisión simple.

Sin(Double)
Devuelve el seno del ángulo especificado.

Sinh(Double)
Devuelve el seno hiperbólico del ángulo especificado.

Sqrt(Double)
Devuelve la raíz cuadrada de un número especificado.

Tan(Double)
Devuelve la tangente del ángulo especificado.

Tanh(Double)
Devuelve la tangente hiperbólica del ángulo especificado.

Truncate(Decimal)
Calcula la parte entera de un número decimal especificado.

Truncate(Double)
Calcula la parte entera de un número de punto flotante de precisión doble
especificado.
*/

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Excercise 9.");
            // Pruebas
            Circulo circulo = new Circulo(3.5);
            Rectangulo rectangulo = new Rectangulo(3.5, 3.5);

            Console.WriteLine($"Circulo: {circulo}");
            Console.WriteLine($"Rectángulo: {rectangulo}");

            Console.WriteLine();
            Console.WriteLine("Area:");
            Console.WriteLine($"Circulo: {circulo.Area()}");
            Console.WriteLine($"Rectángulo: {rectangulo.Area()}");

            Console.WriteLine();
            Console.WriteLine("Perimetro:");
            Console.WriteLine($"Circulo: {circulo.Perimetro()}");
            Console.WriteLine($"Rectángulo: {rectangulo.Perimetro()}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
