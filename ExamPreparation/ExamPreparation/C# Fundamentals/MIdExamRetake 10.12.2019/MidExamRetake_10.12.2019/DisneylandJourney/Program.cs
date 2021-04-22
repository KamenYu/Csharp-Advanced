using System;

namespace DisneylandJourney
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine());
            byte months = byte.Parse(Console.ReadLine());

            double savedMoney = 0;

            for (int i = 1; i <= months; i++)
            {
                bool isOdd = i == 3 || i == 5 || i == 7 || i == 9 || i == 11;
                bool isFourth = i == 4 || i == 8 || i == 12;

                if (isOdd)
                {
                    savedMoney -= savedMoney * 0.16;
                }
                if (isFourth)
                {
                    savedMoney += 0.25 * savedMoney;
                }
                savedMoney += price *0.25;
            }

            if (savedMoney >= price)
            {
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {(savedMoney - price):f2}lv. for souvenirs.");
            }
            else
            {
                Console.WriteLine($"Sorry. You need {(price - savedMoney):f2}lv. more.");
            }


        }
    }
}
