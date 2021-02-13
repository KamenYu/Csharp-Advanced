using System;
using System.Collections.Generic;
using System.Linq;

namespace Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> liquids = new Queue<int>
                (Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Stack<int> ingredients = new Stack<int>
                (Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            Dictionary<int, string> foods = new Dictionary<int, string>()
            {
                {25, "Bread" },
                {50, "Cake"},
                {75, "Pastry" },
                {100, "Fruit Pie" }
            };

            Dictionary<string, int> cookedFood = new Dictionary<string, int>()
            {
                {"Bread", 0 },
                {"Cake", 0 },
                {"Pastry", 0},
                {"Fruit Pie", 0}
            };

            while (liquids.Count > 0 && ingredients.Count > 0)
            {
                int sum = liquids.Peek() + ingredients.Peek();

                string food = IsEnoughToBake(foods, sum);

                if (food == null)
                {
                    liquids.Dequeue();
                    ingredients.Push(ingredients.Pop() + 3); // ???
                }
                else
                {
                    cookedFood[food]++;
                    liquids.Dequeue();
                    ingredients.Pop();
                }                
            }


            if (IsEnoughToPass(cookedFood))
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (liquids.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
            }

            if (ingredients.Count == 0)
            {
                Console.WriteLine("Ingredients left: none");
            }
            else
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ", ingredients)}");
            }

            foreach (var item in cookedFood.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }

        public static bool IsEnoughToPass(Dictionary<string, int> cookedFood)
        {
            int counter = 0;
            foreach (var item in cookedFood)
            {
                if (item.Value >= 1)
                {
                    counter++;
                }
            }

            if (counter == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string IsEnoughToBake(Dictionary<int, string> foods, int sum)
        {
            foreach (var item in foods)
            {
                if (sum == item.Key)
                {
                    return item.Value;
                }
            }

            return null;
        }
    }
}
