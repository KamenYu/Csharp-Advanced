using System;
namespace _4_darts_tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialPoints = int.Parse(Console.ReadLine());
            int counterOfMoves = 0;
           
            while (initialPoints >= 0)
            {
                string sector = Console.ReadLine(); //"number section", "double ring", "triple ring", "bullseye"
                counterOfMoves++;
                if (sector == "bullseye")
                {
                    Console.WriteLine($"Congratulations! You won the game with a bullseye in {counterOfMoves} moves!");  // win
                    break;
                }
                int points = int.Parse(Console.ReadLine());
               
                if (sector == "number section")
                {
                    initialPoints -= points;
                }
                else if (sector == "double ring")
                {
                    initialPoints -= points * 2;
                }
                else if (sector == "triple ring")
                {
                    initialPoints -= points * 3;
                }
               

                if (initialPoints == 0)  // win
                {
                    Console.WriteLine($"Congratulations! You won the game in {counterOfMoves} moves!");
                    break;
                }
            }
            
            if (initialPoints < 0)
            {
                int negativePoints = Math.Abs(initialPoints);
                Console.WriteLine($"Sorry, you lost. Score difference: {negativePoints}.");   // lose
            }
        }
    }
}
