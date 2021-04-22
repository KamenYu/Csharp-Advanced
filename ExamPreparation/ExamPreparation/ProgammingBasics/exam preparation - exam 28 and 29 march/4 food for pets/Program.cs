using System;
namespace _4_food_for_pets
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO find the problem in this task 
            int days = int.Parse(Console.ReadLine());
            double totalFood = double.Parse(Console.ReadLine());
            double dogFoodTotal = 0;
            double catFoodTotal = 0;
            double biscuit = 0;

            for (int i = 1; i <= days; i++)
            {
                int dogFoodPerDay = int.Parse(Console.ReadLine());
                int catFooPerDay = int.Parse(Console.ReadLine());
                dogFoodTotal += dogFoodPerDay;
                catFoodTotal += catFooPerDay;
                if (i % 3 == 0)
                {
                    biscuit = 0.1 * (catFooPerDay + (dogFoodPerDay * 1.0));
                }
            }
            biscuit = Math.Round(biscuit);
            double allFood = catFoodTotal + dogFoodTotal;
            double foodEatenInPercent = allFood / totalFood * 100;
            double dogFoodInPercent = dogFoodTotal * 1.0 / allFood * 100;
            double catFoodInPercent = catFoodTotal * 1.0 / allFood * 100;

            Console.WriteLine($"Total eaten biscuits: {biscuit}gr.");  //"Total eaten biscuits: {количество изядени бисквитки}gr."          
            Console.WriteLine($"{foodEatenInPercent:f2}% of the food has been eaten."); //"{процент изядена храна}% of the food has been eaten."           
            Console.WriteLine($"{dogFoodInPercent:f2}% eaten from the dog.");  //"{процент изядена храна от кучето}% eaten from the dog."
            Console.WriteLine($"{catFoodInPercent:f2}% eaten from the cat.");  //"{процент изядена храна от котката}% eaten from the cat."
        }
    }
}
