using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            // swap row1 col1 row2c col2
            // if invalid = "Ivalid input", continue

            int[] dimensions = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[,] matrix = FillMatrix(dimensions[0], dimensions[1]);
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length > 5 || tokens.Length <= 4 || tokens[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                else
                {
                    int rowF = int.Parse(tokens[1]);
                    int colF = int.Parse(tokens[2]);
                    int rowS = int.Parse(tokens[3]);
                    int colS = int.Parse(tokens[4]);

                    bool isValidRow = rowF >= 0 && rowF < matrix.GetLength(0) && rowS >= 0 && rowS < matrix.GetLength(0);
                    bool isValidCol = colF >= 0 && colF < matrix.GetLength(1) && colS >= 0 && colS < matrix.GetLength(1);

                    if (isValidRow && isValidCol)
                    {
                        string temp = matrix[rowF, colF];
                        matrix[rowF, colF] = matrix[rowS, colS];
                        matrix[rowS, colS] = temp;
                        PrintMatrix(matrix);

                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                }

            }
        }

        private static void PrintMatrix(string[,] matrix)
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

        private static string[,] FillMatrix(int rows, int cols)
        {
            string[,] matrix = new string[rows, cols];

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
