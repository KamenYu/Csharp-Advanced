using System;
using System.Linq;

namespace ExamPreparation
{
    class StartUp
    {
        static void Main(string[] args)
        {
            // for stack and queues
            Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }

        public static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " "); // check if needed
                }
                Console.WriteLine();
            }
        }

        public static string[,] FillMatrix(int rows, int cols)
        {
            string[,] matrix = new string[rows, cols]; // STRING[,]

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] data = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];
                }
            }

            return matrix;
        }
    }
}
