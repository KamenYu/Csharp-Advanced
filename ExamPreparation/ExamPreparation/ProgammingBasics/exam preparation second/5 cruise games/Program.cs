using System;
namespace _5_cruise_games
{
    class Program
    {
        static void Main(string[] args)
        {
            // TO CHECK one test from Judge breaks, but row by row the program is the same with the solution by Sanya Kasarova
            string name = Console.ReadLine();
            int playedGames = int.Parse(Console.ReadLine());

            int voleyballCounter = 0;
            double volleyballCurrent = 0; 

            int tennisCounter = 0;
            double tennisCurrent = 0;

            int badmintonCounter = 0;
            double badmintonCurrent = 0;

            for (int i = 1; i <= playedGames; i++)
            {
                string gameType = Console.ReadLine();  //"volleyball", "tennis", "badminton"
                int gamePoints = int.Parse(Console.ReadLine());

                switch (gameType)
                {
                    case "volleyball":
                        voleyballCounter++;
                        volleyballCurrent += gamePoints + gamePoints * 0.07;
                        break;
                    case "tennis":
                        tennisCounter++;
                        tennisCurrent += gamePoints + gamePoints * 0.05;
                        break;
                    case "badminton":
                        badmintonCounter++;
                        badmintonCurrent += gamePoints + gamePoints * 0.02;
                        break;
                }
            }

            double averageVolleyball = (volleyballCurrent / voleyballCounter);
            double averageTennis = (tennisCurrent / tennisCounter);
            double averageBadminton = (badmintonCurrent / badmintonCounter);

            double sum = Math.Floor(volleyballCurrent + tennisCurrent + badmintonCurrent);

            if (averageBadminton >= 75 &&  averageTennis >= 75 && averageBadminton >= 75)
            {
                Console.WriteLine($"Congratulations, {name}! You won the cruise games with {sum} points.");
            }
            else
            {
                Console.WriteLine($"Sorry, {name}, you lost. Your points are only {sum}.");
            }
        }
    }
}
