using System;
using System.Collections.Generic;
using System.Linq;

namespace MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string[] input = Console.ReadLine()
                .Split();

            while (input[0] != "End")
            {
                switch (input[0])
                {
                    case "Shoot":            // Shoot {index} {power}
                        int indexToShoot = int.Parse(input[1]);
                        int powerToShoot = int.Parse(input[2]);                      

                        if (indexToShoot >= 0 && indexToShoot <= targets.Count - 1)
                        {
                            int temp = targets[indexToShoot];
                            if ((temp -= powerToShoot) <= 0)
                            {
                                targets.RemoveAt(indexToShoot);
                            }
                            else
                            {
                                targets[indexToShoot] -= powerToShoot;
                            }
                        }                                                

                        break;

                    case "Add":              // Add {index} {value}
                        int indexToAdd = int.Parse(input[1]);
                        int valueToAdd = int.Parse(input[2]);

                        if (indexToAdd < 0 || indexToAdd > targets.Count - 1)
                        {
                            Console.WriteLine("Invalid placement!");                            
                        }
                        else
                        {
                            targets.Insert(indexToAdd, valueToAdd);
                        }
                       
                        break;

                    case "Strike":           // Strike {index} {radius}   TO_DO

                        int indexToStrike = int.Parse(input[1]);
                        int power = int.Parse(input[2]);
                        int counter1 = 0;
                        int counter2 = 0;
                       
                        for (int i = 0; i < indexToStrike; i++)
                        {
                            counter1++;
                        }

                        for (int i = indexToStrike + 1; i < targets.Count; i++)
                        {
                            counter2++;
                        }

                        if (counter1 >= power && counter2 >= power)
                        {
                            int rounds = power * 2 + 1;
                            targets.RemoveRange(indexToStrike - power, rounds);
                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");                                
                        }

                        break;
                }
                input = Console.ReadLine().Split();
            }
            Console.WriteLine(String.Join("|", targets));
        }
    }
}
