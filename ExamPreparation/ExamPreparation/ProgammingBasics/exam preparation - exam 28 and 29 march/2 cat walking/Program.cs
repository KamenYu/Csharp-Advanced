using System;
namespace _2_cat_walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minPerWalk = int.Parse(Console.ReadLine());
            int walksPerDay = int.Parse(Console.ReadLine());
            int calories = int.Parse(Console.ReadLine());

            double totalCalPerDay = minPerWalk * walksPerDay * 5;
            double half = calories / 2;
            //double diff = Math.Abs(totalCalPerDay - calories);

            if (totalCalPerDay >= half)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {totalCalPerDay}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {totalCalPerDay}.");
            }
        }
    }
}
