using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4_HitList
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetInfo = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, string>> people = new Dictionary<string, Dictionary<string, string>>();

            string transmission;

            while ((transmission = Console.ReadLine()) != "end transmissions")
            {
                string[] tokens = transmission.Split(new char[] { '=', ';', ':' });
                string[] kvps = tokens.Skip(1).ToArray(); // check

                for (int i = 0; i < kvps.Length; i += 2)
                {
                    string key = kvps[i];
                    string value = kvps[i + 1];

                    if (people.ContainsKey(tokens[0]) == false)
                    {
                        people.Add(tokens[0], new Dictionary<string, string>() { { key, value} });
                    }

                    if (people[tokens[0]].ContainsKey(key) == false)
                    {
                        people[tokens[0]].Add(key, value);
                    }
                    else
                    {
                        people[tokens[0]][key] = value; // check
                    }
                }
            }

            string toKill = Console.ReadLine().Split().ToArray()[1];
            var toKillInfo = people.Where(x => x.Key == toKill).FirstOrDefault();
            int infoIndex = toKillInfo.Value.Sum(s => s.Key.Length);
            infoIndex += toKillInfo.Value.Sum(s => s.Value.Length);

            StringBuilder result = new StringBuilder();
            result.AppendLine($"Info on {toKill}:");

            Dictionary<string, string> toKillInfoResult = people.Where(x => x.Key == toKill).FirstOrDefault().Value;
            foreach (var item in toKillInfoResult.OrderBy(x => x.Key))
            {
                result.AppendLine($"---{item.Key}: {item.Value}");
            }

            Console.WriteLine(result.ToString().Trim());
            Console.WriteLine($"Info index: {infoIndex}");

            if (infoIndex >= targetInfo)
            {
                Console.WriteLine("Proceed");
            }
            else
            {
                Console.WriteLine($"Need {targetInfo - infoIndex} more info.");
            }
        }
    }
}
