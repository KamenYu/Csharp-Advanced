using System;
namespace _5_care_for_puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfFood = int.Parse(Console.ReadLine()) * 1000;
            string command = Console.ReadLine();
            int sum = 0;
            while (command != "Adopted")
            {
                int foodPerEating = int.Parse(command);
                sum += foodPerEating;
                command = Console.ReadLine();
            }
            int diff = Math.Abs(sum - amountOfFood);
            if (sum <= amountOfFood)
            {
                Console.WriteLine($"Food is enough! Leftovers: {diff} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {diff} grams more.");
            }
        }
    }
}
