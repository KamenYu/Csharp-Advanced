using System;
using System.Linq;

namespace HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neghbourhood = Console.ReadLine()
                .Split('@')
                .Select(int.Parse)
                .ToArray();

            string[] commands = Console.ReadLine()
                .Split();                             // Jump {length}
          
            int cupidsPosition = 0;

            while (commands[0] != "Love!")
            {
                int length = int.Parse(commands[1]);
                if (length > neghbourhood.Length)
                {
                    cupidsPosition = 0;
                    neghbourhood[cupidsPosition] -= 2;
                }
                else
                {
                    cupidsPosition += length;
                    if (cupidsPosition >= neghbourhood.Length)
                    {
                        cupidsPosition = 0;
                        neghbourhood[cupidsPosition] -= 2;
                    }
                    else
                    {
                        neghbourhood[cupidsPosition] -= 2;
                    }                   
                }

                if (neghbourhood[cupidsPosition] < 0)
                {
                    neghbourhood[cupidsPosition] = 0;
                    Console.WriteLine($"Place {cupidsPosition} already had Valentine's day.");    // check
                }
                else if (neghbourhood[cupidsPosition] == 0)
                {
                    Console.WriteLine($"Place {cupidsPosition} has Valentine's day.");
                }
                
                commands = Console.ReadLine().Split();
            }
            Console.WriteLine($"Cupid's last position was {cupidsPosition}.");

            int counter = 0;

            for (int i = 0; i < neghbourhood.Length; i++)
            {
                if (neghbourhood[i] == 0)
                {
                    counter++;
                }
            }

            if (counter == neghbourhood.Length)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {neghbourhood.Length - counter} places.");
            }
        }
    }
}
