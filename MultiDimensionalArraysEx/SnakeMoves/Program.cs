using System;
using System.Linq;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte[] dims = Console.ReadLine().Split().Select(sbyte.Parse).ToArray();
            char[,] matrix = new char[dims[0], dims[1]];
            char[] snake = Console.ReadLine().ToCharArray();
            string direction = "right";
            sbyte row = 0;
            sbyte col = 0;
            sbyte s = 0;

            for (int i = 0; i < dims[0] * dims[1]; i++)
            {
                if (snake.Length == s)
                {
                    s = 0;
                }
                matrix[row, col] = snake[s];
                if (direction == "right")
                {
                    col++;
                    if (col == dims[1])
                    {
                        row++;
                        direction = "left";
                    }
                }
                if (direction == "left")
                {
                    col--;
                    if (col == -1)
                    {
                        col++;
                        row++;
                        direction = "right";
                    }
                }
                s++;
            }
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
