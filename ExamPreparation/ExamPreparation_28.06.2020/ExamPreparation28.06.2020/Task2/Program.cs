using System;

namespace Task2
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
                char[] data = Console.ReadLine() .ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];

                    if (matrix[row, col] == 'S')
                    {
                        startRow = row;
                        startCol = col;
                    }
                }
            }

            int food = 0;
            string command = Console.ReadLine();
            while (true)
            {
                matrix[startRow, startCol] = '.';
                              
                startRow = SnakeMoving(startRow, startCol, command)[0];
                startCol = SnakeMoving(startRow, startCol, command)[1];

                if (IsValid(matrix, startRow, startCol) == false)
                {
                    Console.WriteLine("Game over!");
                    break;
                }

                if (matrix[startRow, startCol] == '*')
                {
                    food += 1;
                }
                else if (matrix[startRow, startCol] == 'B')
                {
                    matrix[startRow, startCol] = '.';
                    int[] array = SnakeReapears(matrix, startRow, startCol);
                    startRow = array[0];
                    startCol = array[1];
                }
                else if (matrix[startRow, startCol] == '-')
                {
                    matrix[startRow, startCol] = '.';
                }

                matrix[startRow, startCol] = 'S';

                if (food >= 10)
                {
                    Console.WriteLine("You won! You fed the snake.");
                    break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Food eaten: {food}");
            PrintMatrix(matrix);
        }

        public static int[] SnakeReapears(char[,] matrix, int startRow, int startCol)
        {
            int[] newPosition = null;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        if (row != startRow || col != startCol) // CHECK
                        {
                            newPosition = new int[2] { row, col };
                        }                       
                    }
                }
            }

            return newPosition;
        }

        public static void PrintMatrix(char[,] matrix)
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

        public static int[] SnakeMoving(int row, int col, string command)
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

            int[] snakeCoordinates = new int[2] { row, col };
            return snakeCoordinates;
        }

        public static bool IsValid(char[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }
    }
}
