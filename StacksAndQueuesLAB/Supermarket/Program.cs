using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            string name = string.Empty;

            while ((name = Console.ReadLine()) != "End")
            {
                if (name == "Paid")
                {
                    for (int i = 0; i < queue.Count; i++)
                    {
                        Console.WriteLine(queue.Dequeue());
                        i--;
                    }
                }
                else
                {
                    queue.Enqueue(name);
                }
            }
            Console.WriteLine("{0} people remaining.", queue.Count);
        }
    }
}
