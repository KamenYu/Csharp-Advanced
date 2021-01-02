using System;
using System.Collections.Generic;
namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            string line;
            int carsCrossingCounter = 0;
            while ((line = Console.ReadLine()) != "end")
            {
                if (line == "green")
                {
                    if (n > queue.Count)
                    {
                        for (int i = 0; i < queue.Count; i++)
                        {
                            carsCrossingCounter++;
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            i--;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < n; i++)
                        {
                            carsCrossingCounter++;
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                        }
                    }
                    
                }
                else
                {
                    queue.Enqueue(line);
                }
            }
            Console.WriteLine("{0} cars passed the crossroads.", carsCrossingCounter);
        }
    }
}
