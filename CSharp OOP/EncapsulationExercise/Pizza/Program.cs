using System;

namespace Pizza
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] pizzaName = Console.ReadLine()
                .Split();
            try
            {
                Pizza pizza = new Pizza(pizzaName[1]);

                string[] doughInfo = Console.ReadLine().Split();

                Dough dough = new Dough(doughInfo[1], doughInfo[2], double.Parse(doughInfo[3]));
                pizza.Dough = dough;

                string topping = Console.ReadLine();

                while (topping != "END")
                {
                    string[] toppingInfo = topping.Split();
                    Topping top = new Topping(toppingInfo[1], double.Parse(toppingInfo[2]));
                    pizza.AddTopping(top);

                    topping = Console.ReadLine();
                }

                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:f2} Calories.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }
    }
}
