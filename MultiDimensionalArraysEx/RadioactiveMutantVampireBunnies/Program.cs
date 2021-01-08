using System;
using System.Collections.Generic;
using System.Linq;

namespace RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                        .Split(" ").Select(int.Parse).ToArray();
            char[,] matrix = new char[dimensions[0], dimensions[1]];
            int startRow = 0;
            int startCol = 0;
            List<string> bunnyCoordinates = new List<string>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string data = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];
                    if (matrix[row, col] == 'P')
                    {
                        startRow = row;
                        startCol = col;
                    }
                    else if (matrix[row, col] == 'B')
                    {
                        bunnyCoordinates.Add($"{row},{col}");
                    }
                }
            }

            Queue<char> playerMovements = new Queue<char>(Console.ReadLine().ToCharArray());
            matrix[startRow, startCol] = '.';
            while (true)
            {
                char currentMovement = playerMovements.Dequeue();
                int tempRow = startRow;
                int tempCol = startCol;

                if (currentMovement == 'U')
                {
                    startRow--;
                }
                else if (currentMovement == 'D')
                {
                    startRow++;
                }
                else if (currentMovement == 'L')
                {
                    startCol--;
                }
                else // right
                {
                    startCol++;
                }

                BunnyMultiplication(matrix, bunnyCoordinates);                

                if (IsInside(matrix, startRow, startCol) == false)
                {
                    PrintMatrix(matrix);
                    Console.WriteLine("won: {0} {1}", tempRow, tempCol);
                    break;
                }
                else if (HitByABunny(matrix, startRow, startCol, bunnyCoordinates))
                {
                    PrintMatrix(matrix);
                    Console.WriteLine("dead: {0} {1}", startRow, startCol);
                    break;
                }
            }
        }

        private static bool HitByABunny(char[,] matrix, int startRow, int startCol, List<string> bunnyCoordinates)
        {
            List<string> temp = bunnyCoordinates.ToList();

            while (temp.Count > 0)
            {
                int[] currenrBunnyCoord = temp.First().Split(',').Select(int.Parse).ToArray();
                int bunnyRow = currenrBunnyCoord[0];
                int bunnyCol = currenrBunnyCoord[1];

                if (bunnyRow == startRow && bunnyCol == startCol)
                {
                    return true;
                }

                temp.Remove(temp.First());
            }
            return false;
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

        private static void BunnyMultiplication(char[,] matrix, List<string> bunnyCoordinates)
        {
            List<string> temp = bunnyCoordinates.ToList();

            while (temp.Count > 0)
            {
                int[] currenrBunnyCoord = temp.First().Split(',').Select(int.Parse).ToArray();
                int bunnyRow = currenrBunnyCoord[0];
                int bunnyCol = currenrBunnyCoord[1];                

                if (true)  // Left
                {
                    bunnyCol--;
                    if (IsInside(matrix, bunnyRow, bunnyCol) && matrix[bunnyRow, bunnyCol] == '.')
                    {
                        matrix[bunnyRow, bunnyCol] = 'B';
                        bunnyCoordinates.Add($"{bunnyRow},{bunnyCol}");
                    }
                }

                if (true)  // Right
                {
                    bunnyCol +=2 ;
                    if (IsInside(matrix, bunnyRow, bunnyCol) && matrix[bunnyRow, bunnyCol] == '.')
                    {
                        matrix[bunnyRow, bunnyCol] = 'B';
                        bunnyCoordinates.Add($"{bunnyRow},{bunnyCol}");
                    }
                }

                bunnyCol--;

                if (true)  // directions[0] == 'd'
                {
                    bunnyRow++;
                    if (IsInside(matrix, bunnyRow, bunnyCol) && matrix[bunnyRow, bunnyCol] == '.')
                    {
                        matrix[bunnyRow, bunnyCol] = 'B';
                        bunnyCoordinates.Add($"{bunnyRow},{bunnyCol}");
                    }
                }

                if (true)  // up
                {
                    bunnyRow -= 2;
                    if (IsInside(matrix, bunnyRow, bunnyCol) && matrix[bunnyRow, bunnyCol] == '.')
                    {
                        matrix[bunnyRow, bunnyCol] = 'B';
                        bunnyCoordinates.Add($"{bunnyRow},{bunnyCol}");
                    }
                }
                temp.Remove(temp.First());
            }
        }

        public static bool IsInside(char[,] matrix, int startRow, int startCol)
        {
            return startRow >= 0 && startRow < matrix.GetLength(0) && startCol >= 0 && startCol < matrix.GetLength(1);
        }
    }
}
