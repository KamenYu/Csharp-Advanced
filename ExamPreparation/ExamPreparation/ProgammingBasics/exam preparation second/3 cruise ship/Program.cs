using System;
namespace _3_cruise_ship
{
    class Program
    {
        static void Main(string[] args)
        {
            string cruiseType = Console.ReadLine(); // "Mediterranean", "Adriatic", "Aegean"
            string roomType = Console.ReadLine();   // "standard cabin", "cabin with balcony", "apartment"
            int nights = int.Parse(Console.ReadLine());  // if nights > 7 25% discount
            double sum = 0;

            if (cruiseType == "Mediterranean")
            {
                if (roomType == "standard cabin")
                {
                    sum = nights * 4 * 27.5;
                }
                else if (roomType == "cabin with balcony")
                {
                    sum = nights * 4 * 30.20;
                }
                else if (roomType == "apartment")
                {
                    sum = nights * 4 * 40.50;
                }
            }
            else if (cruiseType == "Adriatic")
            {
                if (roomType == "standard cabin")
                {
                    sum = nights * 4 * 22.99;
                }
                else if (roomType == "cabin with balcony")
                {
                    sum = nights * 4 * 25.0;
                }
                else if (roomType == "apartment")
                {
                    sum = nights * 4 * 34.99;
                }
            }
            else if (cruiseType == "Aegean")
            {
                if (roomType == "standard cabin")
                {
                    sum = nights * 4 * 23.0;
                }
                else if (roomType == "cabin with balcony")
                {
                    sum = nights * 4 * 26.60;
                }
                else if (roomType == "apartment")
                {
                    sum = nights * 4 * 39.80;
                }
            }
            if (nights > 7)
            {
                sum -= sum * 0.25;
            }
            Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {sum:f2} lv.");
        }
    }
}
