using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> nums = new Stack<int>(arr);
            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] tokens = command.Split();
                if (tokens[0] == "add")
                {
                    nums.Push(int.Parse(tokens[1]));
                    nums.Push(int.Parse(tokens[2]));
                }
                else
                {
                    int toRemove = int.Parse(tokens[1]);

                    if (toRemove <= nums.Count)
                    {
                        for (int i = 0; i < toRemove; i++)
                        {
                            nums.Pop();
                        }
                    }
                }
                command = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Sum: {nums.Sum()}");
        }
    }
}
