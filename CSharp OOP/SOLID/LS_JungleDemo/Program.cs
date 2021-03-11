using System;

namespace LS_JungleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal ani = new Lion();
            //Lion ani = new Lion(); LS followed
            ani.Sleep();
            ani.Die();

            Animal animal = new Snake("Ssssssnaaaake");
            animal.Printing();
        }
    }
}
