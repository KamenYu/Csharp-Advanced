using System;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            int cookiesPerDayPerEmployee = int.Parse(Console.ReadLine());
            int employees = int.Parse(Console.ReadLine());
            int otherFactoryTotalCookies = int.Parse(Console.ReadLine());

            double total = 0;

            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    total += Math.Floor(cookiesPerDayPerEmployee * employees * 0.75);
                    continue;
                }
                total += cookiesPerDayPerEmployee * employees;
            }

            Console.WriteLine($"You have produced {total} biscuits for the past month.");

            double diff = Math.Abs(total - otherFactoryTotalCookies);
            double percentage = diff / otherFactoryTotalCookies * 100;

            if (total > otherFactoryTotalCookies)
            {
                Console.WriteLine($"You produce {percentage:f2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {percentage:f2} percent less biscuits.");
            }
        }
    }
}
