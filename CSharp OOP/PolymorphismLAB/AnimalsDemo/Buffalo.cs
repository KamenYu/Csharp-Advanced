using System;
namespace AnimalsDemo
{
    public class Buffalo : Animal
    {
        public override void Sleep()
        {
            Console.WriteLine("Dreaming of the past");
        }

        public override void Eat(object food)
        {
            Console.WriteLine("Eating grass, what else?");
        }
    }
}
