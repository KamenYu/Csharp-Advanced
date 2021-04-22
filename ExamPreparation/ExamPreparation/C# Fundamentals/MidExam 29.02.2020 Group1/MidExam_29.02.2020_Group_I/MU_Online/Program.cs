using System;
using System.Linq;

namespace MU_Online
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dungeonRooms = Console.ReadLine()
                .Split('|');

            int initialHealth = 100;
            int initialBitCoins = 0;
            
            for (int i = 0; i < dungeonRooms.Length; i++)
            {
                string[] commands = dungeonRooms[i]
                .Split();

                if (commands[0] == "potion")
                {
                    int healingPotion = int.Parse(commands[1]);
                    int temp = initialHealth;
                    
                    if (initialHealth + healingPotion > 100)
                    {
                        initialHealth = 100;
                        healingPotion = 100 - temp;
                    }
                    else
                    {
                        initialHealth += healingPotion;
                    }
                    Console.WriteLine($"You healed for {healingPotion} hp.");
                    Console.WriteLine($"Current health: {initialHealth} hp.");
                }
                else if (commands[0] == "chest")
                {
                    int foundBitCoins = int.Parse(commands[1]);
                    initialBitCoins += foundBitCoins;
                    Console.WriteLine($"You found {foundBitCoins} bitcoins.");
                }
                else
                {
                    int monsterAttack = int.Parse(commands[1]);
                    initialHealth -= monsterAttack;

                    if (initialHealth > 0)
                    {
                        Console.WriteLine($"You slayed {commands[0]}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {commands[0]}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                }
            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {initialBitCoins}");
            Console.WriteLine($"Health: {initialHealth}");
        }
    }
}
