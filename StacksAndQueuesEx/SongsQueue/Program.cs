using System;
using System.Collections.Generic;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");

            Queue<string> queue = new Queue<string>(songs);
            string command = Console.ReadLine();

            while (queue.Count > 0)
            {
                if (command.Contains("Play"))
                {
                    if (queue.Count > 0)
                    {
                        queue.Dequeue();
                    }
                }
                else if (command.Contains("Add"))
                {
                    string song = command.Remove(0, 4);
                    if (queue.Contains(song) == false)
                    {
                        queue.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}
