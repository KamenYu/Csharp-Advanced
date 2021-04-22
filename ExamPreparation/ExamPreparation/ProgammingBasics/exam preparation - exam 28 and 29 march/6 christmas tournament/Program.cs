using System;
namespace _6_christmas_tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double total = 0;
            int daysWin = 0;
            int daysLost = 0;
            
            for (int i = 1; i <= days; i++)
            {
                string command = Console.ReadLine(); // sport OR Finish
                int countWin = 0;
                int countLose = 0;
                double winnings = 0;
                while (command != "Finish")
                {
                    string result = Console.ReadLine();   // win or lose                
                    if (result == "win")
                    {
                        winnings += 20;
                        countWin++;
                    }
                    else if (result == "lose")
                    {
                        countLose++;
                    }
                    
                    command = Console.ReadLine();
                }
                if (countWin > countLose)
                {
                    winnings = winnings + (winnings * 0.1);
                    daysWin++;
                }
                else if (countWin < countLose)
                {
                    daysLost++;
                }
                total += winnings;
            }
            if (daysWin > daysLost)
            {
                total = total + (total * 0.2);
                Console.WriteLine($"You won the tournament! Total raised money: {total:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {total:f2}");
            }
        }
    }
}
