using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int[]> pumps = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] amountAndDistance = Console.ReadLine().Split().Select(int.Parse).ToArray();
                pumps.Enqueue(amountAndDistance);
            }

            int counter = 0;
            while (true)
            {
                int currentFuel = 0;
                bool isValid = true;
                for (int i = 0; i < n; i++)
                {
                    int[] removed = pumps.Dequeue();
                    currentFuel += removed[0];

                    if (currentFuel < removed[1])
                    {
                        isValid = false;
                    }
                    currentFuel -= removed[1];
                    pumps.Enqueue(removed);
                }

                if (isValid)
                {
                    break;
                }
                pumps.Enqueue(pumps.Dequeue());
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}