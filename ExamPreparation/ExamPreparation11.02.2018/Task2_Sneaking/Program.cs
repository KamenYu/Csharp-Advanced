using System;
using System.Collections.Generic;

namespace Task2_Sneaking
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[][] room = new char[n][];
            int[] samsCoord = null;
            int[] nikoCoord = null;
            List<Enemy> enemies = new List<Enemy>();

            for (int row = 0; row < room.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                room[row] = new char[input.Length];
                for (int col = 0; col < input.Length; col++)
                {
                    room[row][col] = input[col];

                    if (room[row][col] == 'S')
                    {
                        samsCoord = new int[2] { row, col };
                    }
                    else if(room[row][col] == 'N')
                    {
                        nikoCoord = new int[2] { row, col };
                    }
                    else if(room[row][col] == 'b' || room[row][col] == 'd')
                    {
                        int[] enemyCoord = new int[] { row, col };
                        char name;

                        name = room[row][col] == 'b' ? 'b' : 'd';

                        Enemy enemy = new Enemy(name, enemyCoord);
                        enemies.Add(enemy);
                    }
                }
            }

            char[] commands = Console.ReadLine().ToCharArray();

            for (int i = 0; i < commands.Length; i++)
            {               
                room = EnemiesMovement(enemies, room);

                bool flag = false;
                foreach (Enemy enemy in enemies)
                {
                    bool bDeath = samsCoord[0] == enemy.Coordinates[0] && enemy.Name == 'b' && enemy.Coordinates[1] < samsCoord[1];
                    bool dDeath = samsCoord[0] == enemy.Coordinates[0] && enemy.Name == 'd' && enemy.Coordinates[1] > samsCoord[1];
                    
                    if (bDeath || dDeath)
                    {
                        Console.WriteLine($"Sam died at {samsCoord[0]}, {samsCoord[1]}");
                        room[samsCoord[0]][samsCoord[1]] = 'X';
                        flag = true;
                        break;
                    }                    
                }

                if (flag)
                {
                    break;
                }

                room = Moving(room, commands[i], samsCoord);            

                for (int j = 0; j < enemies.Count; j++)
                {
                    bool sameCoord = samsCoord[0] == enemies[j].Coordinates[0] && samsCoord[1] == enemies[j].Coordinates[1];

                    if (sameCoord)
                    {
                        enemies.Remove(enemies[j]);
                    }
                }

                if (nikoCoord[0] == samsCoord[0])
                {
                    room[nikoCoord[0]][nikoCoord[1]] = 'X';
                    Console.WriteLine("Nikoladze killed!");                    
                    break;
                }
            }

            PrintRoom(room);
        }

        public static char[][] EnemiesMovement(List<Enemy> enemies, char[][] room)
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

        public static void PrintRoom(char[][] room)
        {
            for (int row = 0; row < room.GetLength(0); row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    Console.Write(room[row][col]);
                }
                Console.WriteLine();
            }
        }

        public static char[][] Moving(char[][] room, char command, int[] samsCoord)
        {
            room[samsCoord[0]][samsCoord[1]] = '.';
            switch (command)
            {
                case'U': samsCoord[0]--;
                    break;
                case 'D': samsCoord[0]++;
                    break;
                case 'L': samsCoord[1]--;
                    break;
                case 'R': samsCoord[1]++;
                    break;
            }

            room[samsCoord[0]][samsCoord[1]] = 'S';
            return room;
        }
    }

    public class Enemy
    {
        public Enemy(char name, int[] coodrinates)
        {
            Name = name;
            Coordinates = coodrinates;
        }
        public char Name { get; set; }
        public int[] Coordinates { get; set; }
    }
}
