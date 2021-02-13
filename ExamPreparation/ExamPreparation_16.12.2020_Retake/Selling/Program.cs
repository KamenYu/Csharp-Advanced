using System;

namespace Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = FillMatrix(n);

            int startRow = FindStart(matrix)[0];
            int startCol = FindStart(matrix)[1];
            int sum = 0;
            string command = Console.ReadLine();

            while (true)
            {
                matrix[startRow, startCol] = '-';

                if (command == "up")
                {
                    startRow--;
                }
                else if (command == "down")
                {
                    startRow++;
                }
                else if (command == "left")
                {
                    startCol--;
                }
                else if (command == "right")
                {
                    startCol++;
                }

                if (IsInside(matrix, startRow, startCol) == false)
                {
                    Console.WriteLine("Bad news, you are out of the bakery.");
                    Console.WriteLine($"Money: {sum}");
                    break;
                }

                if (char.IsDigit(matrix[startRow, startCol]))
                {
                    sum += int.Parse(matrix[startRow, startCol].ToString());
                    matrix[startRow, startCol] = 'S';
                }
                else if (matrix[startRow, startCol] == 'O')
                {
                    int[] pillarCoord = FindPillar(matrix);
                    matrix[startRow, startCol] = '-';
                    startRow = pillarCoord[0];
                    startCol = pillarCoord[1];
                }

                if (sum >= 50)
                {
                    Console.WriteLine("Good news! You succeeded in collecting enough money!"); // CHECK
                    Console.WriteLine($"Money: {sum}");
                    break;
                }
                command = Console.ReadLine();
            }

            PrintMatrix(matrix);
        }

        public static bool IsInside(char[,] martix, int row, int col)
        {
            return row >= 0 && row < martix.GetLength(0) && col >= 0 && col < martix.GetLength(1);
        }

        public static int[] FindStart(char[,] matrix)
        {
            int[] coordinates = new int[2];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'S')
                    {
                        coordinates[0] = row;
                        coordinates[1] = col;

                        break;
                    }
                }
            }

            return coordinates;
        }

        public static int[] FindPillar(char[,] matrix)
        {
            int[] coordinates = new int[2];
            int counter = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {                    
                    if (matrix[row, col] == 'O')
                    {
                        counter++;

                        if (matrix[row, col] == 'O' && counter > 1)
                        {
                            coordinates[0] = row;
                            coordinates[1] = col;
                            break;
                        }
                    }                    
                }
            }

            return coordinates;
        }

        public static char[,] FillMatrix(int n)
        {
            char[,] matrix = new char[n,n];

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
