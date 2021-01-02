using System;

namespace KnightMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = FillMatrix(size, size);
            int useless = 0;
            int currentAttacks = 0;
            int rowToZero = 0;
            int colToZero = 0;

            while (true)
            {
                int maxAttacks = 0;

                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        if (matrix[row, col] == 'K')
                        {
                            currentAttacks = CountingAttacks(matrix, row, col, currentAttacks);

                            if (currentAttacks > maxAttacks)
                            {
                                maxAttacks = currentAttacks;
                                rowToZero = row;
                                colToZero = col;
                            }                            
                        }
                        currentAttacks = 0;
                    }
                }

                if (maxAttacks > 0)
                {
                    matrix[rowToZero, colToZero] = '0';
                    useless++;
                }
                else 
                {
                    Console.WriteLine(useless);
                    break;
                }
            }

        }

        private static int CountingAttacks(char[,] matrix, int row, int col, int curAt)
        {
            if (IsInside(matrix,row + 2, col + 1) && matrix[row + 2, col + 1] == 'K')
            {
                curAt++;
            }

            if (IsInside(matrix, row - 2, col + 1) && matrix[row - 2, col + 1] == 'K')
            {
                curAt++;
            }

            if (IsInside(matrix, row + 1, col + 2) && matrix[row + 1, col + 2] == 'K')
            {
                curAt++;
            }

            if (IsInside(matrix, row - 1, col + 2) && matrix[row - 1, col + 2] == 'K')
            {
                curAt++;
            }

            if (IsInside(matrix, row + 2, col - 1) && matrix[row + 2, col - 1] == 'K')
            {
                curAt++;
            }

            if (IsInside(matrix, row - 2, col - 1) && matrix[row - 2, col - 1] == 'K')
            {
                curAt++;
            }

            if (IsInside(matrix, row + 1, col - 2) && matrix[row + 1, col - 2] == 'K')
            {
                curAt++;
            }

            if (IsInside(matrix, row - 1, col - 2) && matrix[row - 1, col - 2] == 'K')
            {
                curAt++;
            }
            return curAt;
        }

        private static bool IsInside(char[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }

        private static char[,] FillMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string data = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];
                }
            }
            return matrix;
        }
    }
}
