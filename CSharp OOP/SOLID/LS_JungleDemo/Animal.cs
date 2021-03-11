using System;

namespace LS_JungleDemo
{
    public abstract class Animal
    {
        public Animal()
        {
            Printing(); // never call virtual methods in ctor, because they call themselves first, then go to the child constructor
        }

        public string Name { get; set; }
        public void Print() // this method violates LS, because the abstract class should not care about the child classes
        {
            if (this is Snake)
            {
                Console.WriteLine("Snake"); // this should go to the child class
            }
            if (this is Lion)
            {
                Console.WriteLine("Roar");
            }
        }

        public virtual void Printing()
        {
            Console.WriteLine("Pringting in base");
            Console.WriteLine(Name);
        }

        public abstract void Run();
        public abstract void Eat();
        public abstract void Sleep();
        public abstract void Die();
    }
}
