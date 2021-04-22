using System;
using System.Linq;
using System.Collections.Generic;

namespace MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sequence = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string[] input = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries);
            int counterOfMoves = 0;
            while (input[0] != "end")
            {
                int index1 = int.Parse(input[0]);
                int index2 = int.Parse(input[1]);
                counterOfMoves++;

                if (index2 == index1 ||
                   (index1 > sequence.Count - 1 || index1 < 0 ||
                   index2 > sequence.Count - 1 || index2 < 0))
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");

                    string penalty = $"-{counterOfMoves}a";
                    sequence.Insert(sequence.Count / 2, penalty);
                    sequence.Insert(sequence.Count / 2, penalty);

                }
                else if (sequence[index1] == sequence[index2])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {sequence[index1]}!");
                    if (index1 > index2)
                    {
                        sequence.RemoveAt(index1);
                        sequence.RemoveAt(index2);
                    }
                    else
                    {
                        sequence.RemoveAt(index2);
                        sequence.RemoveAt(index1);
                    }                    
                }              
                else
                {
                    Console.WriteLine("Try again!");
                }

                if (sequence.Count == 0)
                {
                    Console.WriteLine($"You have won in {counterOfMoves} turns!");
                    break;
                }

                input = Console.ReadLine().Split();
            }
            if (sequence.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(String.Join(" ", sequence));
            }
        }
    }
}
