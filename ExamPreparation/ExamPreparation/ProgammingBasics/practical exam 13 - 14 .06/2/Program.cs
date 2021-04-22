using System;
namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int taskNumber = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());
            string course = Console.ReadLine();    //   "Basics", "Fundamentals", "Advanced"
            double result = 0;
            double exrtaFactors = 0;

            if (course == "Basics")
            {
                if (taskNumber == 1)
                {
                    exrtaFactors = points * 0.08;
                    result = exrtaFactors * 0.8;     //Ако задачата е "1" и курсът е Basics  - 20% по-малко точки.
                }
                else if (taskNumber == 2)
                {
                    result = points * 0.09;
                }
                else if (taskNumber == 3)
                {
                    result = points * 0.09;
                }
                else if (taskNumber == 4)
                {
                    result = points * 0.1;
                }
            }
            else if (course == "Fundamentals")
            {
                if (taskNumber == 1)
                {                  
                    result = exrtaFactors * 0.11;   
                }
                else if (taskNumber == 2)
                {
                    result = points * 0.11;
                }
                else if (taskNumber == 3)
                {
                    result = points * 0.12;
                }
                else if (taskNumber == 4)
                {
                    result = points * 0.13;
                }
            }
            else if (course == "Advanced")
            {
                if (taskNumber == 1)
                {
                    exrtaFactors = points * 0.14;    //Ако курсът е "Advanced",  студентът изкарва 20% повече точки.
                    result = exrtaFactors * 0.2  + exrtaFactors;     
                }
                else if (taskNumber == 2)
                {
                    exrtaFactors = points * 0.14;
                    result = exrtaFactors * 0.2 + exrtaFactors;
                }
                else if (taskNumber == 3)
                {
                    exrtaFactors = points * 0.15;
                    result = exrtaFactors * 0.2 + exrtaFactors;
                }
                else if (taskNumber == 4)
                {
                    exrtaFactors = points * 0.16;
                    result = exrtaFactors + exrtaFactors * 0.2;
                }
            }
                Console.WriteLine($"Total points: {result:f2}");
        }
    }
}
