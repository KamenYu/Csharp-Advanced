using System;
using System.Linq;

namespace SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2x2
            int[] dimensions = Console.ReadLine()
                                    .Split(" ").Select(int.Parse).ToArray();
            char[,] matrix = FillMatrix(dimensions[0], dimensions[1]);
            int squareCounter = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if    (matrix[row,     col]     == matrix[row,     col + 1]
                        && matrix[row,     col + 1] == matrix[row + 1, col + 1]
                        && matrix[row + 1, col + 1] == matrix[row + 1, col]
                        && matrix[row,     col]     == matrix[row + 1,     col])
                    {
                        squareCounter++;
                    }
                }
            }
            Console.WriteLine(squareCounter);
        }

        private static char[,] FillMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];                                      
                }
            }
            return matrix;
        }
    }
}
