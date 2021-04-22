using System;
namespace _1_savings
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double personalCharges = double.Parse(Console.ReadLine());

            double unforseenCharges = 0.3 * budget;
            double savedForOneMOnth = budget - (unforseenCharges + personalCharges);
            double savedMoney = savedForOneMOnth * months;
            double maxPercentToSave = savedForOneMOnth / budget * 100;

            Console.WriteLine($"She can save {maxPercentToSave:f2}%");
            Console.WriteLine($"{savedMoney:f2}");
        }
    }
}
