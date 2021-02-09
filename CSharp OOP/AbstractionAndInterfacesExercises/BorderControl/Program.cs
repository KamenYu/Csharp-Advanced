using System;
using System.Collections.Generic;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            
            List<IBuyer> buyers = new List<IBuyer>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] id = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (id.Length == 4)
                {
                    Citizen cit = new Citizen(id[0], int.Parse(id[1]), id[2], id[3]);
                    buyers.Add(cit);
                }
                else if (id.Length == 3)
                {
                    Rebel reb = new Rebel(id[0], int.Parse(id[1]), id[2]);
                    buyers.Add(reb);
                }

            }

            string input = Console.ReadLine();
            int sum = 0;

            while (input != "End")
            {
                foreach (var b in buyers)
                {                    
                    if (b.Name == input)

                    {
                        b.BuyFood();
                        sum += b.Food;
                    }                    
                }               

                input = Console.ReadLine();
            }

            Console.WriteLine(sum);
        }
    }
}
