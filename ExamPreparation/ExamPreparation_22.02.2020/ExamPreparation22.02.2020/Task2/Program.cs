using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int amountOfCommands = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int startRow = -1;
            int startCol = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] data = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];

                    if (matrix[row, col] == 'f')
                    {
                        startRow = row;
                        startCol = col;
                    }
                }
            }

            bool hasWon = false;
            
            for (int i = 0; i < amountOfCommands; i++)
            {
                string command = Console.ReadLine();
                matrix[startRow, startCol] = '-';
                int[] coord = MovingForward(startRow, startCol, command);
                startRow = coord[0];
                startCol = coord[1];

                if (IsValid(matrix, startRow, startCol) == false)
                {
                    startRow = Warping(matrix, startRow);
                    startCol = Warping(matrix, startCol);
                }

                if (matrix[startRow, startCol] == 'B')
                {
                    int[] forward = MovingForward(startRow, startCol, command);
                    startRow = forward[0];
                    startCol = forward[1];

                }
                else if (matrix[startRow, startCol] == 'T')
                {
                    int[] backward = MovingBackward(startRow, startCol, command);
                    startRow = backward[0];
                    startCol = backward[1];                    
                }

                if (IsValid(matrix, startRow, startCol) == false)
                {
                    startRow = Warping(matrix, startRow);
                    startCol = Warping(matrix, startCol);
                }

                if (matrix[startRow, startCol] == 'F')
                {
                    matrix[startRow, startCol] = 'f';
                    Console.WriteLine("Player won!");
                    hasWon = true;
                    break;
                }                

                if (matrix[startRow, startCol] == '-')
                {
                    matrix[startRow, startCol] = 'f';
                }
            }

            if (hasWon == false)
            {
                Console.WriteLine("Player lost!");
            }
            
            PrintMatrix(matrix);
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

        public static int Warping(char[,] matrix,int rowOrCol)
        {
            if (rowOrCol < 0)
            {
                return matrix.GetLength(0) - 1;
            }
            else if (rowOrCol == matrix.GetLength(0))
            {
                return 0;
            }
            else
            {
                return rowOrCol;
            }
        }

        public static int[] MovingForward(int row, int col, string command)
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

            int[] coordinates = new int[2] { row, col };
            return coordinates;
        }

        public static int[] MovingBackward(int row, int col, string command)
        {
            if (command == "up")
            {
                row++;
            }
            else if (command == "down")
            {
                row--;
            }
            else if (command == "left")
            {
                col++;
            }
            else
            {
                col--;
            }

            int[] coordinates = new int[2] { row, col };
            return coordinates;
        }

        public static bool IsValid(char[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }
    }
}
