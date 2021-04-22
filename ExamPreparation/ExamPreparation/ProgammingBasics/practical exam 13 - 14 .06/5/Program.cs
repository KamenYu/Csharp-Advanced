using System;
namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingStudents = int.Parse(Console.ReadLine());
            int tasks = int.Parse(Console.ReadLine());
            int trainerEnergy = int.Parse(Console.ReadLine());

            int questions = 0;
            int quetionsCounter = 0;
            int tasksCounter = 0;

            while (trainerEnergy > 0)
            {
                trainerEnergy += tasks * 2;
                tasksCounter += tasks;

                startingStudents -= tasks;
                questions = startingStudents * 2;
                quetionsCounter += startingStudents * 2;

                trainerEnergy -= questions * 3;

                if (startingStudents > 10)
                {
                    int rest = startingStudents / 10;
                    startingStudents += rest;
                }
                else
                {
                    Console.WriteLine("The students are too few!");
                    Console.WriteLine($"Problems solved: {tasksCounter}");
                    break;
                }
            }
            if (trainerEnergy <= 0)
            {
                Console.WriteLine("The trainer is too tired!");
                Console.WriteLine($"Questions asked: {quetionsCounter}");
            }
        }
    }
}
