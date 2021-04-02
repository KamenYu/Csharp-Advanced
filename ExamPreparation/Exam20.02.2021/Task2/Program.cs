using System;
using System.Linq;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            List<short> coordinates = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(short.Parse).ToList();

            short counter = 0;

            List<short[]> playerOneShips = new List<short[]>(); // <
            List<short[]> playerTwoCoordShips = new List<short[]>(); // >


            for (short row = 0; row < matrix.GetLength(0); row++)
            {
                string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                char[] data = ReturnCharArray(s);

                for (short col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];
                    short[] ship = new short[] { row, col };
                    if (matrix[row, col] == '<')
                    {
                        playerOneShips.Add(ship);
                    }
                    else if (matrix[row, col] == '>')
                    {
                        playerTwoCoordShips.Add(ship);
                    }
                }
            }
            counter = 0;
            int sunkenShipsOne = 0;
            int sunkenShipsTwo = 0;
            int tempOne = playerOneShips.Count;
            int tempTwo = playerTwoCoordShips.Count;

            while (playerOneShips.Count > 0 && playerTwoCoordShips.Count > 0 && coordinates.Count > 0) // check
            {
                short[] rC = new short[] { coordinates[0], coordinates[1] };
                coordinates.Remove(coordinates[0]);
                coordinates.Remove(coordinates[0]);

                if (IsValid(matrix, rC[0], rC[1]) == false)
                {
                    counter++;
                    continue;
                }
                if (counter % 2 == 0)
                {
                    if (matrix[rC[0], rC[1]] == '>')
                    {
                        short indexT = IndexFinder(rC, playerTwoCoordShips);
                        playerTwoCoordShips.Remove(playerTwoCoordShips[indexT]);
                    }
                    if (matrix[rC[0], rC[1]] == '<')
                    {
                        short indexO = IndexFinder(rC, playerOneShips);
                        playerOneShips.Remove(playerOneShips[indexO]);
                    }
                    if (matrix[rC[0], rC[1]] == '#')
                    {
                        MineExplosion(playerOneShips, playerTwoCoordShips, rC);
                    }
                    sunkenShipsOne += tempOne - (short)playerOneShips.Count + tempTwo - (short)playerTwoCoordShips.Count;
                    tempOne = (short)playerOneShips.Count;
                    tempTwo = (short)playerTwoCoordShips.Count;
                }
                else
                {
                    if (matrix[rC[0], rC[1]] == '<')
                    {
                        short indexO = IndexFinder(rC, playerOneShips);
                        playerOneShips.Remove(playerOneShips[indexO]);
                    }
                    if (matrix[rC[0], rC[1]] == '>')
                    {
                        short indexT = IndexFinder(rC, playerTwoCoordShips);
                        playerTwoCoordShips.Remove(playerTwoCoordShips[indexT]);
                    }
                    if (matrix[rC[0], rC[1]] == '#')
                    {
                        MineExplosion(playerOneShips, playerTwoCoordShips, rC);
                    }
                    sunkenShipsTwo += tempOne - playerOneShips.Count + tempTwo - playerTwoCoordShips.Count;
                    tempOne = playerOneShips.Count;
                    tempTwo = playerTwoCoordShips.Count;
                }
                counter++;
            }

            if (playerTwoCoordShips.Count == 0)
            {
                Console.WriteLine($"Player One has won the game! {sunkenShipsOne} ships have been sunk in the battle.");
            }
            else if (playerOneShips.Count == 0)
            {
                Console.WriteLine($"Player Two has won the game! {sunkenShipsTwo} ships have been sunk in the battle.");
            }
            else
            {
                Console.WriteLine($"It's a draw! Player One has {playerOneShips.Count} ships left. Player Two has {playerTwoCoordShips.Count} ships left.");
            }
        }

        private static short IndexFinder(short[] rC, List<short[]> ships)
        {
            short row = rC[0];
            short col = rC[1];
            short index = 0;
            for (short i = 0; i < ships.Count; i++)
            {
                short shipRow = ships[i][0];
                short shipCol = ships[i][1];

                if (row == shipRow && col == shipCol)
                {
                    index = i;
                }
            }

            return index;
        }

        public static void MineExplosion(List<short[]> playerOneShips, List<short[]> playerTwoCoordShips, short[] mineCoordinates)
        {
            short mineRow = mineCoordinates[0];
            short mineCol = mineCoordinates[1];

            List<short[]> list = new List<short[]>();
            short[] left = new short[] { mineRow, (short)(mineCol - 1) };
            list.Add(left);
            short[] right = new short[] { mineRow, (short)(mineCol + 1) };
            short[] up = new short[] { (short)(mineRow - 1), mineCol };
            short[] down = new short[] { (short)(mineRow + 1), mineCol };
            
            short[] upR = new short[] { (short)(mineRow - 1), (short)(mineCol + 1) };
            short[] upL = new short[] { (short)(mineRow - 1), (short)(mineCol - 1) };
            short[] downR = new short[] { (short)(mineRow + 1), (short)(mineCol + 1) };
            short[] downL = new short[] { (short)(mineRow + 1), (short)(mineCol - 1) };
            list.Add(right); list.Add(up); list.Add(down); list.Add(upL); list.Add(upR); list.Add(downL); list.Add(downR);

            for (short i = 0; i < playerOneShips.Count; i++)
            {
                short row = playerOneShips[i][0];
                short col = playerOneShips[i][1];
                for (short j = 0; j < list.Count; j++)
                {
                    short rowM = list[j][0];
                    short colM = list[j][1];

                    if (row == rowM && col == colM)
                    {
                        playerOneShips.Remove(playerOneShips[i]);

                        i--;
                    }
                }
            }

            for (short i = 0; i < playerTwoCoordShips.Count; i++)
            {
                short row = playerTwoCoordShips[i][0];
                short col = playerTwoCoordShips[i][1];

                for (short j = 0; j < list.Count; j++)
                {
                    short rowM = list[j][0];
                    short colM = list[j][1];

                    if (row == rowM && col == colM)
                    {
                        playerTwoCoordShips.Remove(playerTwoCoordShips[i]);
                        i--;
                    }
                }
            }

        }

        public static bool IsValid(char[,] matrix, short row, short col) // for matrix
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }

        public static char[] ReturnCharArray(string[] s)
        {
            char[] array = new char[s.Length];

            for (short i = 0; i < s.Length; i++)
            {
                array[i] = char.Parse(s[i]);
            }

            return array;
        }
    }
}

