using System;
using System.Linq;

namespace SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = FillMatrix(n, n);
            char symbol = char.Parse(Console.ReadLine());

            bool isThere = false;
            int thatRow = 0;
            int thatCol = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        isThere = true;
                        thatRow = row;
                        thatCol = col;
                        break;
                    }
                }
                if (isThere)
                {
                    break;
                }
            }
            if (isThere)
            {
                Console.WriteLine("({0}, {1})", thatRow, thatCol);
            }
            else
            {
                Console.WriteLine("{0} does not occur in the matrix", symbol);
            }
        }

        public static char[,] FillMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] data = Console.ReadLine().ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];
                }
            }
            return matrix;
        }
    }
}