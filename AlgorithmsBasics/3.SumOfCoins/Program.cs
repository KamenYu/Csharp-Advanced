using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.SumOfCoins
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Greedy algorithm
            // Coins: 1, 9, 10
            // Sum: 27

            int[] coins = Console.ReadLine()
                .Split(new char[] { ' ', ',', ':' }, StringSplitOptions.RemoveEmptyEntries)
                .Skip(1)
                .Select(int.Parse)
                .OrderByDescending(x => x)
                .ToArray();

            List<int> coinsList = coins.ToList();

            string[] line2 = Console.ReadLine()
                .Split(": ", StringSplitOptions.RemoveEmptyEntries);

            int sum = int.Parse(line2[1]);

            Dictionary<int, int> coinsD = new Dictionary<int, int>();
            int change = 0;

            while (change != sum && coinsList.Count != 0)
            {
                for (int i = 0; i < coins.Length; i++)
                {
                    if (change + coins[i] <= sum)
                    {
                        change += coins[i];

                        if (coinsD.ContainsKey(coins[i]) == false)
                        {
                            coinsD.Add(coins[i], 0);
                        }

                        coinsD[coins[i]]++;
                        break;
                    }
                    else
                    {
                        coinsList.Remove(coins[i]);
                    }
                }
            }

            int res = 0;
            foreach (var item in coinsD)
            {
                res += item.Key * item.Value;
            }

            if (res == sum)
            {
                Console.WriteLine($"Number of coins to take: {coinsD.Values.Sum()}");

                foreach (var item in coinsD)
                {
                    Console.WriteLine($"{item.Value} coin(s) with value {item.Key}");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
