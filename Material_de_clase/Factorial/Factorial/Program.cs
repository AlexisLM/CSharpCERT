using System;

namespace Factorial
{

    class Factorial
    {

        public static void Print_Numbers(int num, int limit)
        {
            Console.WriteLine(num);
            if (num < limit)
                Print_Numbers(num + 1, limit);
        }

        public static int GetFactorial(int num)
        {
            return num == 1 ? 1 : GetFactorial(num - 1) * num;
        }

        static void Main()
        {
            Console.WriteLine("Enter something... ");
            int num = Convert.ToInt32(Console.ReadLine());

            int fac = Factorial.GetFactorial(num);

            Console.WriteLine(fac);
            Console.ReadKey(true);

            Factorial.Print_Numbers(1, 100);
        }
    }
}
