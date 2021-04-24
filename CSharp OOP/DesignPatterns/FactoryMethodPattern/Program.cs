using System;
using FactoryMethodPattern.Contracts;
using FactoryMethodPattern.Contracts.Factories;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // the diff with SimpleFactory is that here we can have
            // many factories

            Console.WriteLine("In which continent do you want to play_");
            string continent = Console.ReadLine();

            IAnimalFactory factory = new EuropeFactory();

            if (continent == "Africa")
            {
                factory = new AfricaFactory();
            }

            ICarnivore animal = factory.GetCarnivore();
        }
    }
}
