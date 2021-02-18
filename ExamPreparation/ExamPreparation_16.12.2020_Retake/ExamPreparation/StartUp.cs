using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamPreparation
{
    class StartUp
    {
        static void Main(string[] args)
        {
            // for stack and queues
            Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }

        public static string[,] FillMatrix(int rows, int cols)
        {
            string[,] matrix = new string[rows, cols]; // STRING[,]

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

        public static int Warping(char[,] matrix, int rowOrCol)
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

            // if an element goes out of the matrix range it returns from the other side
        }

        public static int[] SnakeReapears(char[,] matrix, int startRow, int startCol)
        {
            int[] newPosition = null;

            // movement from one part of the matrix to other 
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        if (row != startRow || col != startCol)
                        {
                            newPosition = new int[2] { row, col };
                        }
                    }
                }
            }

            /*
              ...B...
              .......
              .......
              ..B....      */

            return newPosition;
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

            int[] beeCoordinates = new int[2] { row, col };
            return beeCoordinates;
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

        public static bool IsValid(char[,] matrix, int row, int col) // for matrix
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }

        public static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " "); // check if needed
                }
                Console.WriteLine();
            }
        }


        //    <<<JAGGED ARRAY>>>

        public static int[][] FillJagged(int[][] jagged)
        {
            for (int row = 0; row < jagged.Length; row++)
            {
                int[] data = Console.ReadLine()
                    .Split()
                    .Select(int.Parse).ToArray();

                jagged[row] = new int[data.Length];

                for (int col = 0; col < data.Length; col++)
                {
                    jagged[row][col] = data[col];
                }
            }

            return jagged;
        }

        public static bool IsJaggedValid(int[][] jagged, int row, int col)
        {
            return row >= 0 && row < jagged.Length && col >= 0 && col < jagged[row].Length; // boboo fixed
        }

        public static void FlowerBlooming(int[][] jagged, Queue<int[]> flowers)
        {
            while (flowers.Count > 0)
            {
                int[] currentCoord = flowers.Dequeue();

                for (int i = 0; i < jagged.Length; i++)
                {
                    jagged[currentCoord[0]][i]++;
                    jagged[i][currentCoord[1]]++;
                }

                jagged[currentCoord[0]][currentCoord[1]] = 1;
            }


            /*

            0000        0010        1010
            0010    =>  1111   =>   2111
            1000        1010        1121

             
             */

        }

        public static char[][] EnemiesMovement(List<object> enemies, char[][] room) // object == anyClass, that has cooordinates, and a name
        {
            // when b reaches end of row becomes d, b moves to the right, when d reaches beginning of row becomes b, d moves to the left
            for (int i = 0; i < enemies.Count; i++)
            {
                int enemyRow = enemies[i].Coordinates[0];
                int enemyCol = enemies[i].Coordinates[1];

                room[enemyRow][enemyCol] = '.';
                if (enemies[i].Name == 'b') // b
                {
                    enemyCol++;

                    if (enemyCol == room[enemyRow].Length)
                    {
                        enemyCol = room[enemyRow].Length - 1;
                        enemies[i].Name = 'd';
                        room[enemyRow][enemyCol] = 'd';
                    }
                    else
                    {
                        room[enemyRow][enemyCol] = 'b';
                    }
                }
                else // d
                {
                    enemyCol--;

                    if (enemyCol == -1) // or < 0
                    {
                        enemyCol = 0;
                        enemies[i].Name = 'b';
                        room[enemyRow][enemyCol] = 'b';
                    }
                    else
                    {
                        room[enemyRow][enemyCol] = 'd';
                    }
                }

                enemies[i].Coordinates[0] = enemyRow;
                enemies[i].Coordinates[1] = enemyCol;
            }

            return room;
        }

        public static void PrintJagged(int[][] jagged)
        {
            for (int r = 0; r < jagged.Length; r++)
            {
                for (int c = 0; c < jagged[r].Length; c++)
                {
                    Console.Write(jagged[r][c] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
