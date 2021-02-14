using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> bombEffects = new Queue<int>
                (Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Stack<int> bombCasings = new Stack<int>
                (Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            Dictionary<int, string> bombs = new Dictionary<int, string>()
            {
                {40, "Datura Bombs" },
                {60, "Cherry Bombs" },
                {120, "Smoke Decoy Bombs" }
            };

            Dictionary<string, int> madeBombs = new Dictionary<string, int>()
            {
                {"Datura Bombs", 0 },
                {"Cherry Bombs", 0},
                {"Smoke Decoy Bombs", 0}
            };

            while (bombCasings.Count > 0 && bombEffects.Count > 0)
            {
                if (madeBombs["Datura Bombs"] >= 3 && madeBombs["Cherry Bombs"] >= 3 && madeBombs["Smoke Decoy Bombs"] >= 3)
                {
                    Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
                    break;
                }

                int sum = bombEffects.Peek() + bombCasings.Peek();

                if (bombs.ContainsKey(sum))
                {
                    madeBombs[bombs[sum]]++;
                    bombEffects.Dequeue();
                    bombCasings.Pop();
                }
                else
                {
                    bombCasings.Push(bombCasings.Pop() - 5);
                }
            }

            if (madeBombs["Datura Bombs"] < 3 && madeBombs["Cherry Bombs"] < 3 && madeBombs["Smoke Decoy Bombs"] < 3)
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (bombEffects.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine("Bomb Effects: " + string.Join(", ", bombEffects));
            }

            if (bombCasings.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: " + string.Join(", ", bombCasings));
            }

            foreach (var item in madeBombs.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
