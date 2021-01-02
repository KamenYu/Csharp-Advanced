using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletCost = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());
            int[] bulletsArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> bullets = new Stack<int>(bulletsArray);

            int[] locksArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> locks = new Queue<int>(locksArray);
            int prize = int.Parse(Console.ReadLine());
            int bulletCounter = 0;

            while (locks.Any() && bullets.Any())
            {               
                int bullet = bullets.Peek();
                int @lock = locks.Peek();
                bulletCounter++;
                if (bullet <= @lock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                bullets.Pop();                    
                              
                if (bullets.Count > 0 && bulletCounter % barrelSize == 0)
                {
                    Console.WriteLine("Reloading!");
                }               
            }

            if (locks.Count == 0 && bullets.Count >= 0)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${prize - bulletCounter * bulletCost}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
