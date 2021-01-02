using System;
using System.Linq;

namespace SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                                      .Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = FillMatrix(dimensions[0], dimensions[1]);

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sum = 0;
                for (int rows = 0; rows < matrix.GetLength(0); rows++)
                {
                    sum += matrix[rows, col];
                }
                Console.WriteLine(sum);
            }
        }

        public static int[,] FillMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] data = Console.ReadLine()
                                    .Split(" ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];
                }
            }
            return matrix;
        }
    }
}
