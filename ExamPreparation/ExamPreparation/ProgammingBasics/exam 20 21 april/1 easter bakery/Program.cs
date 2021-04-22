using System;

namespace _1_easter_bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	цената на килограм захар е с 25 % по - ниска от тази на килограм брашно
            //•	цената на една кора с яйца е с 10 % по - висока от цената на килограм брашно
            //•	цената на един пакет мая е с 80 % по - ниска от цената на килограм захар

            double flourPricePerKg = double.Parse(Console.ReadLine());
            double flourWeightInKg = double.Parse(Console.ReadLine());
            double sugarWeightInKg = double.Parse(Console.ReadLine());
            int cartonsOfEggs = int.Parse(Console.ReadLine());
            int yeastPacks = int.Parse(Console.ReadLine());

            double sugarPricePerKg = flourPricePerKg - flourPricePerKg * 0.25;
            double eggsPrice = flourPricePerKg + flourPricePerKg * 0.1;
            double yeastPrice = sugarPricePerKg - sugarPricePerKg * 0.8;

            double sum = (flourPricePerKg * flourWeightInKg) + (sugarPricePerKg * sugarWeightInKg) + (eggsPrice * cartonsOfEggs) + (yeastPrice * yeastPacks);
            Console.WriteLine($"{sum:f2}");

        }
    }
}
