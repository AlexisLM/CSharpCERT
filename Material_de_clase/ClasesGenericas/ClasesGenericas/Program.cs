using System;

namespace ClasesGenericas
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<double> stack = new Stack<double>(10);

            stack.Push(5.5);
            stack.Push(10.5);

            double x = stack.Pop();
            double y = stack.Pop();

            Console.WriteLine("x: {0}, y: {1}", x, y);

            Stack<Tortilla> stack1 = new Stack<Tortilla>(10);
            stack1.Push(new Tortilla());
            stack1.Push(new Tortilla());

            Console.WriteLine(stack1.Pop().color);
            Console.WriteLine(stack1.Pop().color);
        }
    }
}
