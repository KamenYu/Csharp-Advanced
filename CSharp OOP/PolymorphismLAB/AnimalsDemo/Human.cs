using System;
namespace AnimalsDemo
{
    public class Human
    {
        public Human(Animal pet)
        {
            Pet = pet;
        }

        public Animal Pet { get; set; }

        public void Feed() // with added Dog the Human can take it and apply the same methods as with any other Pet
        {
            if (Pet is Cat) // using IS is bad, diminished polymorphism, so DO NOT USE it, except for testing
            {
                ((Cat)Pet).Heal();     // if unable returns exception
                (Pet as Cat).Heal();   // if unable return null

                // if(Pet is snake) => Console.WriteLine("I can eat anything!");
            }
            else if (typeof(Snake) == Pet.GetType())
            {
                Console.WriteLine("something"); // does the same thing as IS
            }
            

            Pet.Eat("small animals");
        }

        public void PutToSleep()
        {
            Pet.Sleep();
        }
    }
}
