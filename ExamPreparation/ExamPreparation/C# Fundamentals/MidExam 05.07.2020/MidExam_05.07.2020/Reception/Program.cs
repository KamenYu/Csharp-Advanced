using System;

namespace Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee1 = int.Parse(Console.ReadLine());
            int employee2 = int.Parse(Console.ReadLine());
            int employee3 = int.Parse(Console.ReadLine());

            int amountOfStudents = int.Parse(Console.ReadLine());

            int helpedStudentsPerHour = employee1 + employee2 + employee3;
            int timer = 0;
            

            while (amountOfStudents > 0 )
            {
                timer++;
                if (timer % 4 == 0)
                {
                    continue;
                }
                else
                {
                    amountOfStudents -= helpedStudentsPerHour;                   
                }
            }
            Console.WriteLine($"Time needed: {timer}h.");
        }
    }
}
