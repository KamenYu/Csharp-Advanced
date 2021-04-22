using System;
namespace _6_baking_competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfCompetitors = int.Parse(Console.ReadLine());
            int sumOfPastries = 0;
            double cookiesSum = 0;
            double cakesSum = 0;
            double wafflesSum = 0;

            for (int i = 1; i <= amountOfCompetitors; i++)
            {
                string name = Console.ReadLine();   // name 
                string typeOfPastry = Console.ReadLine();      // "cookies", "cakes", "waffles"  OR "Stop baking!"

                int cookiesCounter = 0;
                int cakesCounter = 0;
                int wafflesCounter = 0;
                
                while (typeOfPastry != "Stop baking!")
                {
                    int amountOfPastries = int.Parse(Console.ReadLine());

                    if (typeOfPastry == "cookies")
                    {
                        cookiesCounter += amountOfPastries;                       
                    }
                    else if (typeOfPastry == "cakes")
                    {
                        cakesCounter += amountOfPastries;
                    }
                    else if (typeOfPastry == "waffles")
                    {
                        wafflesCounter += amountOfPastries;
                    }
                    typeOfPastry = Console.ReadLine();
                }
                sumOfPastries += cookiesCounter + cakesCounter + wafflesCounter;
                cookiesSum += cookiesCounter * 1.5;
                cakesSum += cakesCounter * 7.8;
                wafflesSum += wafflesCounter * 2.3;

                Console.WriteLine($"{name} baked {cookiesCounter} cookies, {cakesCounter} cakes and {wafflesCounter} waffles.");
            }
            Console.WriteLine($"All bakery sold: {sumOfPastries}");

            double charity = cookiesSum + cakesSum + wafflesSum;
           Console.WriteLine($"Total sum for charity: {charity:f2} lv.");
        }
    }
}
