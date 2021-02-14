using System;
using System.Linq;

namespace Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int startRow = -1;
            int startCol = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] data = Console.ReadLine()
                                    .ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];

                    if (matrix[row, col] == 'B')
                    {
                        startRow = row;
                        startCol = col;
                    }
                }
            }


            string command;
            int pollinatedFlowers = 0;

            while ((command = Console.ReadLine()) != "End")
            {
                matrix[startRow, startCol] = '.'; // check

                startRow = BeeMoving(startRow, startCol, command)[0];
                startCol = BeeMoving(startRow, startCol, command)[1];

                if (IsValid(matrix, startRow, startCol) == false)
                {
                    Console.WriteLine("The bee got lost!");
                    break;
                }

                if (matrix[startRow, startCol] == 'f')
                {
                    pollinatedFlowers++;
                }
                else if (matrix[startRow, startCol] == 'O')
                {
                    matrix[startRow, startCol] = '.';
                    startRow = BeeMoving(startRow, startCol, command)[0];
                    startCol = BeeMoving(startRow, startCol, command)[1];

                    if (matrix[startRow, startCol] == 'f')
                    {
                        pollinatedFlowers++;
                    }
                }

                matrix[startRow, startCol] = 'B'; // CHECK
            }

            if (pollinatedFlowers >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {pollinatedFlowers} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - pollinatedFlowers} flowers more");
            }

            PrintMatrix(matrix);
        }

        public static int[] BeeMoving(int row, int col, string command)
        {
            if (command == "up")
            {
                row--;
            }
            else if (command == "down")
            {
                row++;
            }
            else if (command == "left")
            {
                col--;
            }
            else
            {
                col++;
            }

            int[] beeCoordinates = new int[2] { row, col };
            return beeCoordinates;
        }

        public static char[,] FillMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols]; // STRING[,]

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] data = Console.ReadLine()
                                    .ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];
                }
            }

            return matrix;
        }

        public static bool IsValid(char[,] matrix, int row, int col) // for matrix
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }

        public static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]); // check if needed
                }

                Console.WriteLine();
            }
        }
    }  
}
