using System;
using System.Collections.Generic;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            Queue<string> hotPotato = new Queue<string>(names);
            int n = int.Parse(Console.ReadLine());

            while (hotPotato.Count != 1)
            {
                for (int i = 1; i < n; i++)
                {
                    hotPotato.Enqueue(hotPotato.Dequeue());
                }
                Console.WriteLine("Removed {0}", hotPotato.Dequeue());                
            }
            Console.WriteLine("Last is {0}", hotPotato.Dequeue());
        }
    }
}
