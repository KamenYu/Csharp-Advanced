using System;
namespace _6_easter_decorations
{
    class Program
    {
        static void Main(string[] args)
        {
            int customers = int.Parse(Console.ReadLine());                              
            double total = 0;

            for (int i = 1; i <= customers; i++)
            {
                string command = Console.ReadLine();   // "basket", "wreath" или "chocolate bunny" OR "Finish"
                int purchasePerCustomer = 0;
                double bill = 0;
            
                while (command != "Finish")
                {
                    purchasePerCustomer++;
                    
                    if (command == "basket")
                    {
                        bill += 1.5;
                    }
                    else if (command == "wreath")
                    {
                        bill += 3.8;
                    }
                    else if (command == "chocolate bunny")
                    {
                        bill += 7;
                    }                  
                    command = Console.ReadLine();
                }
                if (purchasePerCustomer % 2 == 0)
                {
                    bill = bill * 0.8;
                }
                total += bill;
                if (command == "Finish")
                {
                    Console.WriteLine($"You purchased {purchasePerCustomer} items for {bill:f2} leva.");
                }
            }
            double average = total / customers;
            Console.WriteLine($"Average bill per client is: {average:f2} leva.");
        }
    }
}
