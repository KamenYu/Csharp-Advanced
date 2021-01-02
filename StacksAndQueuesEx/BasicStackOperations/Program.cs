using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
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
            Stack<int> stack = new Stack<int>(nums);

            while (true)
            {
                if (s <= stack.Count)
                {
                    for (int i = 0; i < s; i++)
                    {
                        stack.Pop();
                    }

                    if (stack.Count == 0)
                    {
                        Console.WriteLine("0");
                        break;
                    }
                }

                if (stack.Contains(x))
                {
                    Console.WriteLine("true");
                    break;
                }
                else
                {
                    Console.WriteLine(stack.Min());
                    break;
                }
            }
        }
    }
}

