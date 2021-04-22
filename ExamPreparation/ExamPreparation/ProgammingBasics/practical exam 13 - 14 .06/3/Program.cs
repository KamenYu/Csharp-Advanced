using System;
namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {        // 90/ 100 judge
            int difficulty = int.Parse(Console.ReadLine());
            int convolutions = int.Parse(Console.ReadLine());
            int amountOfPages = int.Parse(Console.ReadLine());

            if (difficulty >= 80 && convolutions >= 80 && amountOfPages >= 8)
            {
                Console.WriteLine("Legacy");
            }
            else if (difficulty <= 30 && amountOfPages <=1)
            {
                Console.WriteLine("Easy");
            }
            else if (difficulty >= 80 && convolutions <= 10)
            {
                Console.WriteLine("Master");
            }
            else if (convolutions >= 50 && amountOfPages >= 2)
            {
                Console.WriteLine("Hard");
            }
            else if (difficulty <= 10)
            {
                Console.WriteLine("Elementary");
            }
            else
            {
                Console.WriteLine("Regular");
            }
        }
    }
}
