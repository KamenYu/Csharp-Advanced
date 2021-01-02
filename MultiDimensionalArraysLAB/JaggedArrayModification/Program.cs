using System;
using System.Linq;

namespace JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rows][];

            for (int row = 0; row < jagged.Length; row++)
            {
                int[] data = Console.ReadLine()
                    .Split()
                    .Select(int.Parse).ToArray();

                jagged[row] = new int[data.Length];

                for (int col = 0; col < data.Length; col++)
                {
                    jagged[row][col] = data[col];
                }
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "END")
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);
                bool isInvalid = false;

                if (row < 0 || row >= jagged.Length || col < 0 || col >= jagged[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    isInvalid = true;
                }

                if (!isInvalid)
                {
                    if (command[0] == "Add")
                    {
                        jagged[row][col] += value;
                    }
                    else
                    {
                        jagged[row][col] -= value;
                    }
                }
                
                command = Console.ReadLine().Split();
            }

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
