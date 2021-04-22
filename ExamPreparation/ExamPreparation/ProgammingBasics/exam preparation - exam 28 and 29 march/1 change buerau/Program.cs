using System;
namespace change_buerau
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitCoins = int.Parse(Console.ReadLine());
            double yuans = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine()); // take out from the total

            //•	1 биткойн = 1168 лева.
            //•	1 китайски юан = 0.15 долара.
            //•	1 долар = 1.76 лева.
            //•	1 евро = 1.95 лева

            double bitCoinsLv = bitCoins * 1168;
            double yuansLv = yuans * 0.15 * 1.76;
            double sum = (bitCoinsLv + yuansLv) / 1.95;
            double total = sum - sum * commission * 0.01;
            Console.WriteLine($"{total:f2}");
        }
    }
}
