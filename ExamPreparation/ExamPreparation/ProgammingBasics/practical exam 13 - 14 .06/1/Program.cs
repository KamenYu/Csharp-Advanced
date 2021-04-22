using System;
namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfStudents = int.Parse(Console.ReadLine());
            int amountOfTasks = int.Parse(Console.ReadLine());

            double sumbissions = Math.Ceiling(amountOfTasks * 2.8);
            double solutions = amountOfStudents * sumbissions;
            double extraSolutions = amountOfStudents * (amountOfTasks / 3);

            double totalSolutions = solutions + extraSolutions;

            double memory = Math.Ceiling(totalSolutions / 10);
            double memoryUsed = 5 * memory;

            Console.WriteLine($"{memoryUsed} KB needed");
            Console.WriteLine($"{totalSolutions} submissions");
        }
    }
}
