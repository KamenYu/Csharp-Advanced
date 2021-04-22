using System;
namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfStudents = double.Parse(Console.ReadLine());
            int seasons = int.Parse(Console.ReadLine());

            double examOne = 0;
            double examTwo = 0;
            double toContinue = 0;
            double toReWrite = 0;
           
            for (int i = 1; i <= seasons; i++)
            {               
                examOne = Math.Ceiling(amountOfStudents * 0.9);
                examTwo = Math.Ceiling(examOne * 0.9);
                
                toContinue = Math.Ceiling(examTwo * 0.8);
                if (i % 3 == 0)
                {
                    toReWrite = Math.Ceiling(toContinue * 0.15);
                }
                else
                {
                    toReWrite = Math.Ceiling(toContinue * 0.05);
                }
                
                amountOfStudents = toContinue + toReWrite;
            }
            Console.WriteLine($"Students: {amountOfStudents}");
        }
    }
}
