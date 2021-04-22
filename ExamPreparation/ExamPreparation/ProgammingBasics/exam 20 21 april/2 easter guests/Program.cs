using System;
namespace _2_easter_guests
{
    class Program
    {
        static void Main(string[] args)
        {
            double guests = double.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double kozunaciAmount = Math.Ceiling(guests / 3);
            double kozunaciPrice = kozunaciAmount * 4;
            double eggsAmount = guests * 2;
            double eggsPrice = eggsAmount * 0.45;

            double total = kozunaciPrice + eggsPrice;
            double diff = Math.Abs(budget - total);

            if (budget >= total)
            {
                Console.WriteLine($"Lyubo bought {kozunaciAmount} Easter bread and {eggsAmount} eggs.");
                Console.WriteLine($"He has {diff:f2} lv. left.");                   
            }
            else
            {
                Console.WriteLine($"Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {diff:f2} lv. more.");
            }
        }
    }
}
