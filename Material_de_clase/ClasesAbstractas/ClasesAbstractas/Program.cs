using System;

namespace ClasesAbstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animales =
            {
                new Carnivoro("Leon"),
                new Herviboro("Jirafa")
            };

            Console.WriteLine("Lista de animales");

            foreach(Animal animal in animales)
            {
                Console.WriteLine(animal);
            }

            Lobo lobo = new Lobo("Lobezno");
            lobo.Cazar();

            (lobo as Carnivoro).Cazar();

            Pinguino pingu = new Pinguino("Tux");
            pingu.Cazar();
            //(pingu as Carnivoro).Cazar();

            Console.ReadLine();
        }
    }
}
