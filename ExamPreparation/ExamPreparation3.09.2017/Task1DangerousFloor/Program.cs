using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1DangerousFloor
{
    class Program
    {
        static void Main(string[] args)
        {
            // 100 /100
            char[,] board = new char[8, 8];
            List<Piece> piecesAndPositions = new List<Piece>();
            for (int row = 0; row < board.GetLength(0); row++)
            {
                string s = Console.ReadLine();
                char[] input = RemoveComas(s);

                for (int col = 0; col < board.GetLength(1); col++)
                {
                    board[row, col] = input[col];

                    if (   board[row, col] == 'K'
                        || board[row, col] == 'B'
                        || board[row, col] == 'R'
                        || board[row, col] == 'Q'
                        || board[row, col] == 'P')
                    {
                        string coordinates = row.ToString() + " " + col.ToString();
                        Piece piece = new Piece(board[row, col], row, col);
                        piecesAndPositions.Add(piece);
                    }
                }
            }

            string move;

            while ((move = Console.ReadLine()) != "END")
            {
                char[] movingCoordinates = move.ToCharArray();
                char name = movingCoordinates[0];
                int startRow = int.Parse(movingCoordinates[1].ToString());
                int startCol = int.Parse(movingCoordinates[2].ToString());

                int currentRow = -1;
                int currentCol = -1;
                // piecesAndPositions.Where(n => n.Name == name).Select(x => x.Row).FirstOrDefault()
                foreach (var item in piecesAndPositions)
                {
                    if (item.Name == name && item.Row == startRow && item.Col == startCol)
                    {
                        currentRow = item.Row;
                        currentCol = item.Col;
                        break;
                    }
                }

                int goingToRow = int.Parse(movingCoordinates[4].ToString());
                int goingToCol = int.Parse(movingCoordinates[5].ToString());

                if (currentRow < 0 && currentCol < 0)
                {
                    Console.WriteLine("There is no such a piece!");
                    continue;
                }

                PieceMoves(startRow, startCol, goingToRow, goingToCol, name, piecesAndPositions);

                int movedRow = piecesAndPositions.Where(r => r.Name == name && r.Row == goingToRow && r.Col == goingToCol).Select(r => r.Row).FirstOrDefault();
                int movedCol = piecesAndPositions.Where(r => r.Name == name && r.Row == goingToRow && r.Col == goingToCol).Select(r => r.Col).FirstOrDefault();

                if (!AreValid(board, movedRow, movedCol))
                {
                    Console.WriteLine("Move go out of board!");
                    Piece piece = new Piece(name, currentRow, currentCol);
                    Piece toRemove = piecesAndPositions.Where(n => n.Name == name && n.Row == goingToRow && n.Col == goingToCol).FirstOrDefault();
                    piecesAndPositions.Remove(toRemove);
                    piecesAndPositions.Add(piece);
                }
            }
        }

        public static bool AreValid(char[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }

        public static char[] RemoveComas(string s)
        {
            string[] removedComas = s.Split(',');
            char[] input = new char[removedComas.Length];

            for (int i = 0; i < removedComas.Length; i++)
            {
                input[i] = char.Parse(removedComas[i]);
            }

            return input;
        }

        public static void PieceMoves(int startRow, int startCol, int goingToRow, int goingToCol,
            char name, List<Piece> piecesAndPositions)
        {
            // modelling pieces movements

            bool up =          startRow - 1 == goingToRow && startCol == goingToCol;
            bool down =        startRow + 1 == goingToRow && startCol == goingToCol;                                      
            bool right =       startRow == goingToRow     && startCol + 1 == goingToCol;
            bool left =        startRow == goingToRow     && startCol - 1 == goingToCol;
                                      
            bool upRight =     startRow - 1 == goingToRow && startCol + 1 == goingToCol;           
            bool upLeft =      startRow - 1 == goingToRow && startCol - 1 == goingToCol;                                      
            bool downRight =   startRow + 1 == goingToRow && startCol + 1 == goingToCol;
            bool downLeft =    startRow + 1 == goingToRow && startCol - 1 == goingToCol;

            bool upRightBQ =   startRow > goingToRow      && startCol < goingToCol;
            bool upLeftBQ =    startRow > goingToRow      && startCol > goingToCol;  
            bool downRightBQ = startRow < goingToRow      && startCol < goingToCol;
            bool downLeftBQ =  startRow < goingToRow      && startCol > goingToCol;
            bool diagonalBQ =  Math.Abs(startRow - goingToRow) == Math.Abs(startCol - goingToCol);

            bool rightRQ =     startRow == goingToRow     && startCol < goingToCol;
            bool leftRQ =      startRow == goingToRow     && startCol > goingToCol;
            bool upRQ =        startRow > goingToRow      && startCol == goingToCol;
            bool downRQ =      startRow < goingToRow      && startCol == goingToCol;

            bool flag = true;
            Piece piece = new Piece(name, goingToRow, goingToCol);
            Piece toRemove = piecesAndPositions.Where(n => n.Name == name && n.Row == startRow && n.Col == startCol).FirstOrDefault();

            if (name == 'K')
            {
                if (up || down
                || left || right
                || downLeft || downRight
                || upLeft || upRight)
                {                   
                    flag = false;
                }
            }
            else if (name == 'B')
            {                
                if ((upLeftBQ || upRightBQ || downLeftBQ || downRightBQ) && diagonalBQ)
                {
                    flag = false;
                }
            }
            else if (name == 'R')
            {
                if (upRQ || downRQ || leftRQ || rightRQ)
                {
                    flag = false;
                }
            }
            else if (name == 'P')
            {
                if (up)
                {
                    flag = false;
                }
            }
            else if (name == 'Q')
            {
                if (((upLeftBQ || upRightBQ || downLeftBQ || downRightBQ) && diagonalBQ)
                    || upRQ || downRQ || leftRQ || rightRQ )
                {                    
                    flag = false;
                }
            }
            
            if (flag)
            {
                Console.WriteLine("Invalid move!");
            }
            else
            {
                piecesAndPositions.Remove(toRemove);
                piecesAndPositions.Add(piece);
            }
        }

        public class Piece
        {
            public Piece(char name, int row, int col)
            {
                Name = name;
                Row = row;
                Col = col;
            }

            public char Name { get; set; }
            public int Row { get; set; }
            public int Col { get; set; }
        }
    }
}
