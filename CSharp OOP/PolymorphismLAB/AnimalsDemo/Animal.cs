using System;
namespace AnimalsDemo
{
    public class Animal
    {
        public virtual void Eat(object food)
        {
            Console.WriteLine("Eating " + food);
        }

        public virtual void Sleep()
        {
            Console.WriteLine("Sleeping");
        }
    }
}
