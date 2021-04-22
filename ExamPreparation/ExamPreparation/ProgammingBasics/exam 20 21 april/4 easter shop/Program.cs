using System;
namespace _4_easter_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsAtTheBeginning = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();   // "Close" , "Buy" , "Fill"
            int soldEggs = 0;

            while (command != "Close")
            {                
                int ifEggs = int.Parse(Console.ReadLine());
                
                if (command == "Buy")
                {
                    if (ifEggs > eggsAtTheBeginning)
                    {
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {eggsAtTheBeginning}.");
                        break;
                    }
                    eggsAtTheBeginning -= ifEggs;
                    soldEggs += ifEggs;                 
                }
                else if (command == "Fill")
                {
                    eggsAtTheBeginning += ifEggs;
                }
               
                command = Console.ReadLine();             
            }
            if (command == "Close")
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine($"{soldEggs} eggs sold.");
            }
        }
    }
}
