using System;
namespace _5_easter_bake
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfKozunaci = int.Parse(Console.ReadLine());
            double sugarAmount = 0;
            double flourAmount = 0;
            int sugarMax = -1000000;
            int flourMax = -1000000;

            for (int i = 0; i < amountOfKozunaci; i++)
            {
                int sugar = int.Parse(Console.ReadLine());
                int flour = int.Parse(Console.ReadLine());

                sugarAmount += sugar;
                flourAmount += flour;

                if (sugar > sugarMax)
                {
                    sugarMax = sugar;
                }
                if (flour > flourMax)
                {
                    flourMax = flour;
                }
            }

            double sugarPacks = Math.Ceiling(sugarAmount / 950);
            double flourPacks = Math.Ceiling(flourAmount / 750);

            Console.WriteLine($"Sugar: {sugarPacks}");
            Console.WriteLine($"Flour: {flourPacks}");
            Console.WriteLine($"Max used flour is {flourMax} grams, max used sugar is {sugarMax} grams.");
        }
    }
}
