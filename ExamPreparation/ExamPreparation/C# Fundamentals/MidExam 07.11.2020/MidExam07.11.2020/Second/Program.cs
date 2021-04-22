using System;
using System.Linq;
using System.Collections.Generic;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namesList = Console.ReadLine()
                .Split(", ")
                .ToList();

            string[] input = Console.ReadLine()
                .Split();

            int blacklisted = 0;
            int lost = 0;

            while (input[0] != "Report")
            {
                switch (input[0])
                {
                    case "Blacklist":
                        string nameToBlacklist = input[1];
                        int blacklistIndex = namesList.IndexOf(input[1]);

                        if (namesList.Contains(input[1]))
                        {
                            Console.WriteLine($"{input[1]} was blacklisted.");
                            namesList[blacklistIndex] = "Blacklisted";
                            blacklisted++;
                        }
                        else
                        {
                            Console.WriteLine($"{input[1]} was not found.");
                        }

                        break;

                    case "Error":

                        int errorIndex = int.Parse(input[1]);

                        if (namesList[errorIndex] != "Blacklisted" && namesList[errorIndex] != "Lost")
                        {
                            Console.WriteLine($"{namesList[errorIndex]} was lost due to an error.");
                            namesList[errorIndex] = "Lost";
                            lost++;
                        }

                        break;

                    case "Change":

                        int changeIndex = int.Parse(input[1]);
                        string newName = input[2];

                        if (changeIndex >= 0 && changeIndex <= namesList.Count - 1)
                        {
                            Console.WriteLine($"{namesList[changeIndex]} changed his username to {newName}.");
                            namesList[changeIndex] = newName;
                        }

                        break;

                    default:
                        break;
                }

                input = Console.ReadLine().Split();
            }
            Console.WriteLine($"Blacklisted names: {blacklisted}");
            Console.WriteLine($"Lost names: {lost}");
            Console.WriteLine(String.Join(' ', namesList));
        }
    }
}
