using System;
namespace AnimalsDemo
{
    public class Snake : Animal
    {
        public override void Eat(object food)
        {
            if (food is Program == false)
            {
                Console.WriteLine("I only eat your programmes");
            }
        }
    }
}
