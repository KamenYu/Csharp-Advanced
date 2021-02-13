using System;
using System.Collections.Generic;
using System.Linq;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rC= Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[][] jagged = new int[rC[0]][];

            for (int row = 0; row < jagged.Length; row++)
            {

                jagged[row] = new int[rC[1]];

                for (int col = 0; col < rC[1]; col++)
                {
                    jagged[row][col] = 0;
                }
            }

            Queue<int[]> flowers = new Queue<int[]>();
            string command;
            while ((command = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                int[] coordinates = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (IsJaggedValid(jagged, coordinates[0], coordinates[1]))
                {
                    jagged[coordinates[0]][coordinates[1]] = 1;
                    flowers.Enqueue(coordinates);
                }
                else
                {
                    Console.WriteLine("Invalid coordinates.");
                    continue;
                }
            }

            FlowerBlooming(jagged, flowers);
            PrintJagged(jagged);
        }

        public static void FlowerBlooming(int[][] jagged, Queue<int[]> flowers)
        {
            while (flowers.Count > 0)
            {
                int[] currentCoord = flowers.Dequeue();

                for (int i = 0; i < jagged.Length; i++)
                {
                    jagged[currentCoord[0]][i]++;
                    jagged[i][currentCoord[1]]++;
                }

                jagged[currentCoord[0]][currentCoord[1]] = 1;
            }           
        }

        public static bool IsJaggedValid(int[][] jagged, int row, int col)
        {
            return row >= 0 && row < jagged.Length && col >= 0 && col < jagged[row].Length; // boboo fixed
        }

        public static void PrintJagged(int[][] jagged)
        {
            for (int r = 0; r < jagged.Length; r++)
            {
                for (int c = 0; c < jagged[r].Length; c++)
                {
                    Console.Write(jagged[r][c] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
