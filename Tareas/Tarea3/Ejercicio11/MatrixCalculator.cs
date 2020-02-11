using System;

/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

namespace Ejercicio11
{
    static class MatrixCalculator
    {
        /// <summary>
        /// Adds two matrices.
        /// </summary>
        /// <param name="m1">First operating.</param>
        /// <param name="m2">Second operating.</param>
        /// <returns>Result of the operation.</returns>
        private static double[,] Addition(double[,] m1, double[,] m2)
        {
            return AdditionSubstraction(m1, m2, true);
        }

        /// <summary>
        /// Substracts two matrices.
        /// </summary>
        /// <param name="m1">First operating.</param>
        /// <param name="m2">Second operating.</param>
        /// <returns>Result of the operation.</returns>
        private static double[,] Substraction(double[,] m1, double[,] m2)
        {
            return AdditionSubstraction(m1, m2, false);
        }

        /// <summary>
        /// Adds or substracts two matrices <paramref name="m1"/> and
        /// <paramref name="m2"/>.
        /// </summary>
        /// <param name="m1">First operating.</param>
        /// <param name="m2">Second operating.</param>
        /// <param name="operation">
        /// True if the operation is addition or False if the operation is
        /// substraction.
        /// </param>
        /// <returns>Result of the operation.</returns>
        private static double[,] AdditionSubstraction(double[,] m1,
            double[,] m2, bool operation)
        {
            // Result and indexes
            double[,] result = new double[m1.GetLength(0), m1.GetLength(1)];
            ushort x, y;

            // Generate result
            for (y = 0; y < m1.GetLength(0); y++)
                for (x = 0; x < m1.GetLength(1); x++)
                    result[y, x] = operation ? m1[y, x] + m2[y, x] :
                        m1[y, x] - m2[y, x];

            return result;
        }

        /// <summary>
        /// Returns the product of <paramref name="m1"/> and
        /// <paramref name="m2"/>.
        /// </summary>
        /// <param name="m1">First operating.</param>
        /// <param name="m2">Second operating.</param>
        /// <returns></returns>
        private static double[,] Product(double[,] m1, double[,] m2)
        {
            // Result and indexes
            double[,] result = new double[m1.GetLength(0), m1.GetLength(1)];
            ushort x, y, z;

            // Generate result
            for (y = 0; y < m1.GetLength(0); y++)
                for (x = 0; x < m1.GetLength(1); x++)
                {
                    result[y, x] = 0;
                    for (z = 0; z < m1.GetLength(0); z++)
                        result[y, x] += m1[y, z] * m2[z, x];
                }

            return result;
        }

        /// <summary>
        /// Prints elements of the matrix <paramref name="m"/>.
        /// </summary>
        /// <param name="m">Matrix to print.</param>
        private static void PrintMatrix(double[,] m)
        {
            ushort x, y; // Indexes

            Console.WriteLine();
            for (y = 0; y < m.GetLength(0); y++)
            {
                for (x = 0; x < m.GetLength(1); x++)
                    Console.Write($"{m[y, x]}\t");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Prints the program menu.
        /// </summary>
        private static void PrintMenu()
        {
            string menu = "Select one of the following options [1-3]:\n" +
                "1] Matrix sum.\n2] Matrix substraction.\n3] Matrix product." +
                "\nOther] Exit.\n----------------------------------\nOption: ";
            Console.Write(menu);
        }

        /// <summary>
        /// Prints the matrix operation with its operatings.
        /// </summary>
        /// <param name="m1">First operating.</param>
        /// <param name="m2">Second operating.</param>
        /// <param name="m3">Result.</param>
        /// <param name="oper">Operator.</param>
        private static void PrintOperation(double[,] m1, double[,] m2,
            double[,] m3, string oper)
        {
            PrintMatrix(m1);
            Console.WriteLine($"    {oper}");
            PrintMatrix(m2);
            Console.WriteLine("    =");
            PrintMatrix(m3);
        }

        /// <summary>
        /// Runs the MatrixCalculator program.
        /// </summary>
        public static void Run()
        {
            string option;  // Selected option
            ushort size;    // Matrix size
            double[,] m1;   // First operating
            double[,] m2;   // Second operating
            double[,] m3;   // Result
            int x, y, z;    // Indexes to iterate matrix

            // Print menu and get option
            PrintMenu();
            option = Console.ReadLine();

            if (option.Equals("1") || option.Equals("2") || option.Equals("3"))
            {
                // Get size and create matrices
                Console.Write("Enter matrix size: ");
                size = Convert.ToUInt16(Console.ReadLine());
                m1 = new double[size, size];
                m2 = new double[size, size];

                // Fill matrices
                for (z = 1; z <= 2; z++)
                {
                    Console.WriteLine(); // Line break.
                    for (y = 0; y < size; y++)
                        for (x = 0; x < size; x++)
                        {
                            Console.Write($"Enter value for M{z}[{y},{x}]: ");
                            if (z == 1)
                                m1[y, x] = Convert.ToDouble(Console.ReadLine());
                            else
                                m2[y, x] = Convert.ToDouble(Console.ReadLine());
                        }
                }

                if (option.Equals("1")) // Addition
                {
                    m3 = Addition(m1, m2);
                    PrintOperation(m1, m2, m3, "+");
                }
                else if (option.Equals("2")) // Substraction
                {
                    m3 = Substraction(m1, m2);
                    PrintOperation(m1, m2, m3, "-");
                }
                else if (option.Equals("3")) // Product
                {
                    m3 = Product(m1, m2);
                    PrintOperation(m1, m2, m3, "*");
                }
            }
        }
    }
}
