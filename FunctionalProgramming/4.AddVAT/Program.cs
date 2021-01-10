using System;
using System.Linq;

namespace _4.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            // VAT = 20 % || 1.2
            Func<decimal, decimal> addingVat = x => x * 1.2m;
            decimal[] prices = Console.ReadLine()
                .Split(", ")
                .Select(decimal.Parse)
                .Select(addingVat)
                .ToArray();

            foreach (var item in prices)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}
