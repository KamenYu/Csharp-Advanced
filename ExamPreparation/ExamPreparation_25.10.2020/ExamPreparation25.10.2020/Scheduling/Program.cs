using System;
using System.Collections.Generic;
using System.Linq;

namespace Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> tasks = new Stack<int>
                (Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            Queue<int> threads = new Queue<int>
                (Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            int taskToKill = int.Parse(Console.ReadLine());

            while (true)
            {
                int currentTask = tasks.Peek();
                int currentThread = threads.Peek();

                if (currentTask == taskToKill)
                {
                    Console.WriteLine($"Thread with value {currentThread} killed task {taskToKill}");
                    Console.WriteLine(string.Join(" ", threads));
                    break;
                }
                else
                {
                    if (currentThread >= currentTask)
                    {
                        tasks.Pop();
                        threads.Dequeue();
                    }
                    else
                    {
                        threads.Dequeue();
                    }
                }
            }
        }
    }
}

