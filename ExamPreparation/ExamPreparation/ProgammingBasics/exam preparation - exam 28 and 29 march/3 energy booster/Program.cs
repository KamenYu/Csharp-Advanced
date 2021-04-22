using System;
namespace _3_energy_booster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine(); //  "Watermelon", "Mango", "Pineapple" или "Raspberry"
            string set = Console.ReadLine();   // "small" или "big"
            int amountOfSets = int.Parse(Console.ReadLine());
            double sum = 0;

            //               Диня         Манго             Ананас            Малина
            //2 броя(small)  56 лв./ бр.  36.66 лв./ бр.   42.10 лв./ бр.   20 лв./ бр.
            //5 броя(big)    28.70 лв./ бр.   19.60 лв./ бр.   24.80 лв./ бр.   15.20 лв./ бр.
            //if sum 
            //•	от 400 лв.до 1000 лв.включително има 15 % отстъпка
            //•	над 1000 лв.има 50 % отстъпка

            if (fruit == "Watermelon")
            {
                if (set == "small")
                {
                    sum = 2 * amountOfSets * 56.00;
                }
                else if (set == "big")
                {
                    sum = 5 * amountOfSets * 28.70;
                }
            }
            else if (fruit == "Mango")
            {
                if (set == "small")
                {
                    sum = 2 * amountOfSets * 36.66;
                }
                else if (set == "big")
                {
                    sum = 5 * amountOfSets * 19.60;
                }
            }
            else if (fruit == "Pineapple")
            {
                if (set == "small")
                {
                    sum = 2 * amountOfSets * 42.10;
                }
                else if (set == "big")
                {
                    sum = 5 * amountOfSets * 24.80;
                }
            }
            else if (fruit == "Raspberry")
            {
                if (set == "small")
                {
                    sum = 2 * amountOfSets * 20.00;
                }
                else if (set == "big")
                {
                    sum = 5 * amountOfSets * 15.20;
                }
            }

            if (sum >= 400 && sum <= 1000)
            {
                sum = sum - (sum * 0.15);
            }
            else if (sum > 1000)
            {
                sum = sum - (sum * 0.5);
            }
            Console.WriteLine($"{sum:f2} lv.");
        }
    }
}
