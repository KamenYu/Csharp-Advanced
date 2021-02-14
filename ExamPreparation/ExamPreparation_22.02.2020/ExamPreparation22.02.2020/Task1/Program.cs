using System;
using System.Linq;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> lootBoxOne = new Queue<int>
                (Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            Stack<int> lootBoxTwo = new Stack<int>
                (Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            int sum = 0;

            while (lootBoxOne.Count > 0 && lootBoxTwo.Count > 0)
            {
                if ((lootBoxOne.Peek() + lootBoxTwo.Peek()) % 2 == 0)
                {
                    sum += lootBoxOne.Dequeue() + lootBoxTwo.Pop();
                }
                else
                {
                    lootBoxOne.Enqueue(lootBoxTwo.Pop());
                }
            }

            if (lootBoxOne.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (sum >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {sum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {sum}");
            }
        }
    }
}
