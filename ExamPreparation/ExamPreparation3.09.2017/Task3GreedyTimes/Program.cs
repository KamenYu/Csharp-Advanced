using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3GreedyTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            // ulong or decimal
            ulong bagCapacity = ulong.Parse(Console.ReadLine());
            List<string> voltInventory = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<string, Dictionary<string, ulong>> itemsInfo = new Dictionary<string, Dictionary<string, ulong>>();
            // veru wrong, very difficult
            int firstGold = voltInventory.IndexOf("Gold");

            if (firstGold < 0)
            {
                return;
            }

            ulong total = 0;
            for (int i = firstGold; i < voltInventory.Count; i += 2)
            {
                string itemType = voltInventory[i].ToLower();
                bool IsGem = itemType.Contains("gem", StringComparison.CurrentCulture);

                ulong amount = ulong.Parse(voltInventory[i + 1]);

                if (total > bagCapacity)
                {
                    return;
                }

                if (itemType == "gold")
                {
                    total += amount;
                    if (itemsInfo.ContainsKey("Gold") == false)
                    {
                        itemsInfo.Add("Gold", new Dictionary<string, ulong>());
                        itemsInfo["Gold"].Add(voltInventory[i], amount);
                    }
                    else
                    {
                        itemsInfo["Gold"][voltInventory[i]] += amount;
                    }
                }
                else if (IsGem && itemsInfo.ContainsKey("Gold") && itemsInfo["Gold"].Values.First() >= amount)
                {
                    total += amount;
                    if (itemsInfo.ContainsKey("Gem") == false)
                    {
                        itemsInfo.Add("Gem", new Dictionary<string, ulong>());
                        itemsInfo["Gem"].Add(voltInventory[i], amount);
                    }
                    else
                    {
                        itemsInfo["Gem"][voltInventory[i]] += amount;
                    }
                }
                else if(itemType.Length == 3 && itemsInfo["Gold"].Values.First() >= amount && itemsInfo["Gem"].Values.First() >= amount)
                {
                    total += amount;
                    if (itemsInfo.ContainsKey("Cash") == false)
                    {
                        itemsInfo.Add("Cash", new Dictionary<string, ulong>());
                        itemsInfo["Cash"].Add(voltInventory[i], amount);
                    }
                    else
                    {
                        itemsInfo["Cash"][voltInventory[i]] += amount;
                    }
                }               
            }
        }
    }
}
