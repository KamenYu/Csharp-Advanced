using System;
using System.Linq;
using System.Collections.Generic;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split(", ")
                .ToList();

            string[] commands = Console.ReadLine()
                .Split(" - ");

            while (commands[0] != "Craft!")
            {
                switch (commands[0])
                {
                    case "Collect":

                        if(list.Contains(commands[1]) == false)
                        {
                            list.Add(commands[1]);
                        }
                        break;

                    case "Drop":
                        if (list.Contains(commands[1]))
                        {
                            list.Remove(commands[1]);
                        }
                        break;

                    case "Combine Items":                            // Combine Items - {oldItem}:{newItem}"
                        string[] separated = commands[1].Split(':');
                        string oldItem = separated[0];
                        string newItem = separated[1];
                        int index = list.IndexOf(oldItem);

                        if (list.Contains(oldItem))
                        {
                            if (index + 1 == list.Count)
                            {
                                list.Add(newItem);
                            }
                            else
                            {
                                list.Insert(index + 1, newItem);
                            }
                        }
                        break;

                    case "Renew":
                        if (list.Contains(commands[1]))
                        {
                            list.Remove(commands[1]);
                            list.Add(commands[1]);
                        }
                        break;
                }
                commands = Console.ReadLine().Split(" - ");
            }
            Console.WriteLine(String.Join(", ", list));
        }
    }
}
