using System;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int initialBonus = int.Parse(Console.ReadLine());

            int attendace;
            double totalBonus = 0;
            double maxBonus = 0;
            int maxAttendance = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                attendace = int.Parse(Console.ReadLine());

                totalBonus = (attendace * 1.0 / lecturesCount) * (5 + initialBonus);

                if (maxBonus < totalBonus)
                {
                    maxBonus = totalBonus;
                    maxAttendance = attendace;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Round(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");
        }
    }
}
