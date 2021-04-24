using System;

namespace SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = AnimalFactory.CreateAnimal("Bad Dog");
        }
    }
}
