using System;
using System.Linq;

namespace TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int waitingPeople = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int temp = 0;

            for (int i = 0; i < wagons.Length; i++)
            {
                int currentWagon = wagons[i];
                int diff = 0;
                if (currentWagon < 4)
                {
                    diff = 4 - currentWagon;
                    temp = waitingPeople;
                    waitingPeople -= diff;

                    if (waitingPeople < 0)
                    {
                        wagons[i] += temp;
                        waitingPeople = 0;
                        temp = 0;
                        if (wagons[i] < 0)
                        {
                            wagons[i] = 0;
                        }
                    }
                    else
                    {
                        wagons[i] = 4;
                    }
                }
                else
                {
                    continue;
                }                
            }

            int counter = 0;

            for (int i = 0; i < wagons.Length; i++)
            {
                if (wagons[i] == 4)
                {
                    counter++;
                }
            }

            if (counter == wagons.Length)
            {
                if (waitingPeople > 0)
                {
                    Console.WriteLine($"There isn't enough space! {waitingPeople} people in a queue!");
                    Console.WriteLine(String.Join(" ", wagons));
                }
                if (waitingPeople == 0)
                {
                    Console.WriteLine(String.Join(" ", wagons));
                }
            }
            else
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(String.Join(" ", wagons));
            }
        }
    }
}
