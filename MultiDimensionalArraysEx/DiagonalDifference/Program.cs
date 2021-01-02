using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = FillMatrix(n, n);
            int dOne = 0;
            int dTwo = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        dOne += matrix[row, col];
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == 0 && col == matrix.GetLength(1) - 1)
                    {
                        dTwo += matrix[row, col];
                        while (row < matrix.GetLength(0) && col > 0)
                        {
                            row++;
                            col--;
                            dTwo += matrix[row, col];
                        }
                    }
                }
            }
            Console.WriteLine(Math.Abs(dOne - dTwo));
        }

        private static int[,] FillMatrix(int rows, int cols)
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
