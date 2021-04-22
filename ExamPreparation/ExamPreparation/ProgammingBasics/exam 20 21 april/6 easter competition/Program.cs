using System;
namespace _6_easter_competition
{
    class Program
    {
        static void Main(string[] args)
        {           
            int kozunaciAmount = int.Parse(Console.ReadLine());
            string nameMax = "";
            int maxPoints = -10000000;

            for (int i = 0; i < kozunaciAmount; i++)
            {
                string name = Console.ReadLine();
                string command = Console.ReadLine();
                int points = 0;
                while (command != "Stop")
                {
                    int grade = int.Parse(command);
                    points += grade;
                    command = Console.ReadLine();

                }
                Console.WriteLine($"{name} has {points} points.");
                if (points > maxPoints)
                {
                    maxPoints = points;
                    nameMax = name;
                    Console.WriteLine($"{name} is the new number 1!");
                }
            }
            Console.WriteLine($"{nameMax} won competition with {maxPoints} points!");        
        }
    }
}
