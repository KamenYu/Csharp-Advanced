using System;

namespace AnimalsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal pet1 = new Snake();
            Animal pet2 = new Cat();
            // regardless of the type of animal , human can take it
            // the reason why polymorphism is powerful is when we create a new class Dog f.e.
            Animal pet3 = new Dog();
            Animal pet4 = new Buffalo();
            Human dogLover = new Human(pet4);

            Animal pet5 = new Animal();
            Cat cat = pet5 as Cat;
            cat.Heal();

            Human catLover = new Human(pet2);
            Human snakeLover = new Human(pet1);
            while (true)
            {
                Console.ReadLine();
                catLover.Feed();
                catLover.PutToSleep();
                snakeLover.Feed();
                snakeLover.PutToSleep();
                dogLover.Feed();
                dogLover.PutToSleep();
            }
        }
    }
}
