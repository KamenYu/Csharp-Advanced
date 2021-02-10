using System;

namespace AnimalsDemo
{
    public class Cat : Animal
    {
        public override void Sleep()
        {
            Console.WriteLine("Sleeping but prepared to catch a mouse"); ;
        }

        public void Heal()
        {
            Console.WriteLine("Purring");
        }
    }
}
