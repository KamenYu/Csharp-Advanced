using System;

namespace CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int wonBattles = 0;


            while(command != "End of battle")
            {
                int distance = int.Parse(command);

                if (initialEnergy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {initialEnergy} energy");
                    return;
                }
                else
                {
                    initialEnergy -= distance;
                    wonBattles++;
                }

                
                if (wonBattles % 3 == 0)
                {
                    initialEnergy += wonBattles;
                }


                command = Console.ReadLine();
            }
            Console.WriteLine($"Won battles: {wonBattles}. Energy left: {initialEnergy}");

        }
    }
}
