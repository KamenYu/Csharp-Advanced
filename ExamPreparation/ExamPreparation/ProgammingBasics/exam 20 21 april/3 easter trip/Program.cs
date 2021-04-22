using System;
namespace _3_easter_trip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();  //"France", "Italy" или "Germany"
            string dates = Console.ReadLine();  // "21-23", "24-27" или "28-31"
            int nights = int.Parse(Console.ReadLine());
            int sum = 0;

            if (dates == "21-23")
            {
                if (destination == "France")
                {
                    sum = nights * 30;
                }
                else if (destination == "Italy")
                {
                    sum = nights * 28;
                }
                else if (destination == "Germany")
                {
                    sum = nights * 32;
                }
            }
            if (dates == "24-27")
            {
                if (destination == "France")
                {
                    sum = nights * 35;
                }
                else if (destination == "Italy")
                {
                    sum = nights * 32;
                }
                else if (destination == "Germany")
                {
                    sum = nights * 37;
                }
            }
            if (dates == "28-31")
            {
                if (destination == "France")
                {
                    sum = nights * 40;
                }
                else if (destination == "Italy")
                {
                    sum = nights * 39;
                }
                else if (destination == "Germany")
                {
                    sum = nights * 43;
                }
            }
            Console.WriteLine($"Easter trip to {destination} : {sum:f2} leva.");
        }
    }
}
