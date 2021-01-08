using System;
using System.Collections.Generic;
using System.Linq;

namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
             /*  * – a regular position on the field.
                 e – the end of the route. 
                 c - coal
                 s - the place where the miner starts */

            int size = int.Parse(Console.ReadLine());
            Queue<string> commands = new Queue<string>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)); // SSO.REE was the problem
            char[,] matrix = FillMatrix(size, size);
            int[] startCoodrinates = new int[2];
            int[] endCoordinates = new int[2];            
            List<string> coalCoordinates = new List<string>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'c')
                    {
                        coalCoordinates.Add($"{row},{col}");
                    }
                    else if (matrix[row, col] == 's')
                    {
                        startCoodrinates[0] = row;
                        startCoodrinates[1] = col;
                    }
                    else if (matrix[row, col] == 'e')
                    {
                        endCoordinates[0] = row;
                        endCoordinates[1] = col;
                    }
                }
            }
            int startRow = startCoodrinates[0];
            int startCol = startCoodrinates[1];
            int coalCounter = 0;

            while (commands.Count > 0)
            {
                string direction = commands.Dequeue();
                int tempRow = startRow;
                int tempCol = startCol;

                if (direction == "up")
                {
                    startRow--;
                }
                else if (direction == "down")
                {
                    startRow++;
                }
                else if (direction == "left")
                {
                    startCol--;
                }
                else // right
                {
                    startCol++;
                }                

                if (IsInside(matrix, startRow, startCol))
                {
                    if (startRow == endCoordinates[0] && startCol == endCoordinates[1])
                    {
                        Console.WriteLine($"Game over! ({startRow}, {startCol})");
                        return;
                    }
                    else if (IsCoal(startRow, startCol, coalCoordinates))
                    {
                        matrix[startRow, startCol] = '*';
                        coalCounter++;
                        coalCoordinates.Remove($"{startRow},{startCol}");
                    }
                }
                else
                {
                    startRow = tempRow;
                    startCol = tempCol;
                }

                if (coalCoordinates.Count == 0)
                {
                    Console.WriteLine($"You collected all coals! ({startRow}, {startCol})");
                    return;
                }
            }
            Console.WriteLine($"{coalCoordinates.Count} coals left. ({startRow}, {startCol})");
        }

        public static bool IsCoal(int startRow, int startCol, List<string> coalCoord)
        {
            List<string> temp = coalCoord.ToList();
            while (temp.Count > 0)
            {
                int[] coalCoordinates = temp.First().Split(',').Select(int.Parse).ToArray();
                int coalRow = coalCoordinates[0];
                int coalCol = coalCoordinates[1];

                if (startRow == coalRow && startCol == coalCol)
                {                    
                    return true;
                }
                temp.Remove(temp.First());
            }
            return false;
        }

        public static bool IsInside(char[,] matrix, int startRow, int startCol)
        {
            return startRow >=0 && startRow < matrix.GetLength(0) && startCol >= 0 && startCol < matrix.GetLength(1);
        }

        public static char[,] FillMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];
                }
            }
            return matrix;
        }
    }
}
