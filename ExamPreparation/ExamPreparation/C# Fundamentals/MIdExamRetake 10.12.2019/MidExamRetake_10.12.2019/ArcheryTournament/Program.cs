using System;
using System.Linq;

namespace ArcheryTournament
{
    class Program
    {
        // 90 / 100
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split('|')
                .Select(int.Parse)
                .ToArray();

            string[] input = Console.ReadLine()
                .Split('@');

            int points = 0;

            while (input[0] != "Game over")
            {
                // 10|10|10|10|10
                string[] command = input[0].Split();

                if (command[0] == "Shoot")
                {
                    int startIndex = int.Parse(input[1]);
                    int length = int.Parse(input[2]);

                    if (startIndex > array.Length || startIndex < 0)
                    {
                        input = Console.ReadLine().Split('@');
                        continue;
                    }
                   
                    if (command[1] == "Right") // /
                    {                                              
                        int position = (startIndex + length) % array.Length;
                        points = Points(array, points, position);                      
                    }
                    else // \
                    {
                        int position = (array.Length - length + startIndex) % array.Length; // this is not my idea
                        points = Points(array, points, position);
                    }

                }
                else if (command[0] == "Reverse")
                {
                    array = array.Reverse().ToArray();
                }               

                input = Console.ReadLine().Split('@');
            }
            Console.WriteLine(String.Join(" - ",array));
            Console.WriteLine($"Iskren finished the archery tournament with {points} points!");
        }

        static int Points(int[] array, int points, int position)
        {
            if (array[position] <= 5)
            {
                points += array[position];
                array[position] = 0;
            }
            else
            {
                points += 5;
                array[position] -= 5;
            }
            return points;
        }
    }
}