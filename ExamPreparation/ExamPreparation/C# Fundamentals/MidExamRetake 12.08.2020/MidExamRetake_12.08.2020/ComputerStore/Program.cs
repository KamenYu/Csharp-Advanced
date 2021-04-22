using System;

namespace ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double priceWithoutTaxes = 0;

            while ((input != "regular") && (input != "special"))
            {
                double givenPrice = double.Parse(input);
                if (givenPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    priceWithoutTaxes += givenPrice;
                }

                input = Console.ReadLine();
            }

            if (priceWithoutTaxes > 0)
            {
                double taxes = priceWithoutTaxes * 0.2;
                double priceWithTaxes;
                if (input == "special")
                {
                    double sum = priceWithoutTaxes + taxes;
                    priceWithTaxes = sum - (sum * 0.1);
                }
                else
                {
                    priceWithTaxes = priceWithoutTaxes + taxes;
                }
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {priceWithoutTaxes:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine(new string('-', 11));
                Console.WriteLine($"Total price: {priceWithTaxes:f2}$");
            }
            else
            {
                Console.WriteLine("Invalid order!");
            }
        }
    }
}
