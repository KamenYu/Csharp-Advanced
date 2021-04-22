using System;
namespace easter_lunch
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Козунак  – 3.20 лв.
            //•	Яйца –  4.35 лв.за кора с 12 яйца
            //•	Курабии – 5.40 лв.за килограм
            //•	Боя за яйца - 0.15 лв.за яйце
            //Вход
            //От конзолата се четат 3 реда:
            //•	Брой козунаци -цяло число в интервала[0 … 99]
            //•	Брой кори с яйца -цяло число в интервала[0 … 99]
            //•	Килограми курабии -цяло число в интервала[0 … 99]

            int kozunaci = int.Parse(Console.ReadLine());
            int cartonsOfEggs = int.Parse(Console.ReadLine());
            int cookies = int.Parse(Console.ReadLine());

            double kozunaciPrice = kozunaci * 3.2;
            double eggsPrice = cartonsOfEggs * 4.35;
            double eggsWithDye = cartonsOfEggs * 12 * 0.15;
            double cookiesPrice = cookies * 5.4;

            double sum = kozunaciPrice + eggsWithDye + cookiesPrice + eggsPrice;
            Console.WriteLine($"{sum:f2}");

        }
    }
}
