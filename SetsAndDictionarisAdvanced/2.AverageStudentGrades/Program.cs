using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> studentLog = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < num; i++)
            {
                string[] studentInfo = Console.ReadLine().Split();
                string name = studentInfo[0];
                decimal grade = decimal.Parse(studentInfo[1]);

                if (studentLog.ContainsKey(name) == false)
                {
                    studentLog.Add(name, new List<decimal>() {});
                }

                studentLog[name].Add(grade);                
            }

            foreach (var student in studentLog)
            {
                Console.Write($"{student.Key} -> "); //student.Value)} (avg: {student.Value.Average():f2})");

                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.Write($"(avg: { student.Value.Average():f2})");
                Console.WriteLine();
            }
        }
    }
}
