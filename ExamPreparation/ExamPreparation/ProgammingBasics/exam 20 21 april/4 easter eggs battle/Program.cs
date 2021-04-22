using System;
namespace _4_easter_eggs_battle
{
    class Program
    {
        static void Main(string[] args)
        {
            int player1 = int.Parse(Console.ReadLine());
            int player2 = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();  // "one" , "two" , OR "End of battle"

            // Играта приключва, ако някой от играчите остане без яйца
            while (command != "End of battle")
            {
                if (command == "one")
                {
                    player2--;
                }
                else if (command == "two")
                {
                    player1--;
                }

                if (player1 == 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {player2} eggs left.");
                    break;
                }
                if (player2 == 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {player1} eggs left.");
                    break;
                }
                command = Console.ReadLine();
            }
            if (command == "End of battle")
            {
                Console.WriteLine($"Player one has {player1} eggs left.");
                Console.WriteLine($"Player two has {player2} eggs left.");
            }
        }
    }
}
