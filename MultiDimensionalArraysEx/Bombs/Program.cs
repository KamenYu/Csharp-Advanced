using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = FillMatrix(size, size);
            List<string> bombsCoordinates = Console.ReadLine().Split().ToList();
            int aliveCells = 0;
            int aliveCellsSum = 0;

            while (bombsCoordinates.Count > 0)
            {
                string[] tokens = bombsCoordinates.First().Split(',');
                int bombRow = int.Parse(tokens[0]);
                int bombCol = int.Parse(tokens[1]);
                bombsCoordinates.Remove($"{tokens[0]},{tokens[1]}");
                int bomb = matrix[bombRow, bombCol];
                IsInside(matrix, bombRow, bombCol);
                Explosion(matrix, bombRow, bombCol, bomb);
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        aliveCells++;
                        aliveCellsSum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine("Alive cells: {0}", aliveCells);
            Console.WriteLine("Sum: {0}", aliveCellsSum);
            PrintMatrix(matrix);
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Explosion(int[,] matrix, int bombRow, int bombCol, int bomb)
        {
            if (bomb > 0)
            {
                if (IsInside(matrix, bombRow, bombCol + 1) && matrix[bombRow, bombCol + 1] > 0)
                {
                    matrix[bombRow, bombCol + 1] -= bomb;
                }

                if (IsInside(matrix, bombRow - 1, bombCol + 1) && matrix[bombRow - 1, bombCol + 1] > 0)
                {
                    matrix[bombRow - 1, bombCol + 1] -= bomb;
                }

                if (IsInside(matrix, bombRow + 1, bombCol + 1) && matrix[bombRow + 1, bombCol + 1] > 0)
                {
                    matrix[bombRow + 1, bombCol + 1] -= bomb;
                }

                if (IsInside(matrix, bombRow, bombCol - 1) && matrix[bombRow, bombCol - 1] > 0)
                {
                    matrix[bombRow, bombCol - 1] -= bomb;
                }

                if (IsInside(matrix, bombRow - 1, bombCol - 1) && matrix[bombRow - 1, bombCol - 1] > 0)
                {
                    matrix[bombRow - 1, bombCol - 1] -= bomb;
                }

                if (IsInside(matrix, bombRow + 1, bombCol - 1) && matrix[bombRow + 1, bombCol - 1] > 0)
                {
                    matrix[bombRow + 1, bombCol - 1] -= bomb;
                }

                if (IsInside(matrix, bombRow - 1, bombCol) && matrix[bombRow - 1, bombCol] > 0)
                {
                    matrix[bombRow - 1, bombCol] -= bomb;
                }

                if (IsInside(matrix, bombRow + 1, bombCol) && matrix[bombRow + 1, bombCol] > 0)
                {
                    matrix[bombRow + 1, bombCol] -= bomb;
                }

                matrix[bombRow, bombCol] = 0;
            }
        }

        public static bool IsInside(int[,] matrix, int bombRow, int bombCol)
        {
            return bombRow >= 0 && bombRow < matrix.GetLength(0) && bombCol >= 0 && bombCol < matrix.GetLength(1);
        }

        public static int[,] FillMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];
                }
            }
            return matrix;
        }
    }
}
