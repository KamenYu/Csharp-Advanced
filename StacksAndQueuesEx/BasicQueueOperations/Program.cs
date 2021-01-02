using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] keys = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = keys[0];  // to push
            int s = keys[1];  // to pop if it is bigger?
            int x = keys[2];  // is it there

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(nums);

            while (true)
            {
                if (s <= queue.Count)
                {
                    for (int i = 0; i < s; i++)
                    {
                        queue.Dequeue();
                    }

                    if (queue.Count == 0)
                    {
                        Console.WriteLine("0");
                        break;
                    }
                }

                if (queue.Contains(x))
                {
                    Console.WriteLine("true");
                    break;
                }
                else
                {
                    Console.WriteLine(queue.Min());
                    break;
                }
            }
        }
    }
}

