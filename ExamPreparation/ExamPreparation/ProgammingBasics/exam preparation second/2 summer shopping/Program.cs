using System;
namespace _2_summer_shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            double beachTowel = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double beachUmbrella = 2.0 /3 * beachTowel;
            double flipFlops = beachUmbrella * 0.75;
            double beachBag = (beachTowel + flipFlops) / 3;

            double sum = beachUmbrella + beachTowel + beachBag + flipFlops;
            double discounted = sum - (sum * discount / 100);
            double diff = Math.Abs(budget - discounted);

            if (budget >= discounted)
            {
                Console.WriteLine($"Annie's sum is {discounted:f2} lv. She has {diff:f2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Annie's sum is {discounted:f2} lv. She needs {diff:f2} lv. more.");
            }
        }
    }
}
