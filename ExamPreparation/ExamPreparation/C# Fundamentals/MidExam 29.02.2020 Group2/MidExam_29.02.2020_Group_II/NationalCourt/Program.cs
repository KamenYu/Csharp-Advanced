using System;

namespace NationalCourt
    {
        class Program
        {
            static void Main(string[] args)
            {
                int employee1 = int.Parse(Console.ReadLine());
                int employee2 = int.Parse(Console.ReadLine());
                int employee3 = int.Parse(Console.ReadLine());

                int amountOfPeople = int.Parse(Console.ReadLine());

                int helpedPeoplePerHour = employee1 + employee2 + employee3;
                int timer = 0;


                while (amountOfPeople > 0)
                {
                    timer++;
                    if (timer % 4 == 0)
                    {
                        continue;
                    }
                    else
                    {
                        amountOfPeople -= helpedPeoplePerHour;
                    }
                }
                Console.WriteLine($"Time needed: {timer}h.");
            }
        }
    }


