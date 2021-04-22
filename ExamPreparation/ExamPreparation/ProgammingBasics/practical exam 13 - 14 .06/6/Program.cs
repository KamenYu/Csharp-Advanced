using System;
namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
             // 990 / 100 Judge
            string command = Console.ReadLine();              // Midnight   OR name                 

            while (command != "Midnight")
            {            
                double pointsSum = 0;
                double toHundred = 0;
                double grade = 0;            

                for (int i = 1; i <= 6; i++)
                {
                    int points = int.Parse(Console.ReadLine());
                    if (points < 0)
                    {
                        Console.WriteLine($"{command} was cheating!");                      
                        break;
                    }
                    pointsSum += points;                  
                }

                toHundred = Math.Floor(pointsSum / 600 * 100);
                grade = toHundred * 0.06;
             
                if (grade < 3 && grade > 1)
                {
                    grade = 2;
                    Console.WriteLine($"{command} - {grade:f2}");
                }
                else if (grade < 5 && grade >= 3)
                {
                    Console.WriteLine($"{command} - {grade:f2}");
                }
                else if (grade >= 5)
                {
                    Console.WriteLine("===================");
                    Console.WriteLine("|   CERTIFICATE   |");
                    Console.WriteLine($"|    {grade:f2}/6.00    |");
                    Console.WriteLine("===================");
                    Console.WriteLine($"Issued to {command}");
                }
                command = Console.ReadLine();
            }
        }
    }
}
