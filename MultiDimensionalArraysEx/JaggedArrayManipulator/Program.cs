using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] jagged = new double[rows][];

            for (int row = 0; row < jagged.Length; row++)
            {
                int[] data = Console.ReadLine()
                    .Split()
                    .Select(int.Parse).ToArray();

                jagged[row] = new double[data.Length];

                for (int col = 0; col < data.Length; col++)
                {
                    jagged[row][col] = data[col];
                }
            }

            MultiplyOrDivideMatrixRowsByTwo(jagged);

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);
                bool isInvalid = row < 0 || row >= jagged.Length || col < 0 || col >= jagged[row].Length;

                if (!isInvalid)
                {
                    if (command[0] == "Add")
                    {
                        jagged[row][col] += value;
                    }
                    else if (command[0] == "Subtract")
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

        private static void MultiplyOrDivideMatrixRowsByTwo(double[][] jagged)
        {
            for (int rows = 0; rows < jagged.Length - 1; rows++)
            {
                if (jagged[rows].Length == jagged[rows + 1].Length)
                {
                    for (int cols = 0; cols < jagged[rows].Length; cols++)
                    {
                        jagged[rows][cols] *= 2;
                        jagged[rows + 1][cols] *= 2;
                    }
                }
                else
                {
                    for (int cols = 0; cols < jagged[rows].Length; cols++)
                    {
                        jagged[rows][cols] /= 2;
                    }
                    for (int cols = 0; cols < jagged[rows + 1].Length; cols++)
                    {
                        jagged[rows + 1][cols] /= 2;
                    }
                }
            }
        }
    }
}