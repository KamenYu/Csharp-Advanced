using System;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Puppy bo = new Puppy();
            bo.Eat();
            bo.Weep();

            Cat maca = new Cat();
            maca.Eat();
            maca.Meow();
            
        }
    }
}
