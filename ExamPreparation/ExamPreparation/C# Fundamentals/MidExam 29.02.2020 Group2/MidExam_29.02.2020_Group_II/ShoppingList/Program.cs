using System;
using System.Linq;
using System.Collections.Generic;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine()
                .Split('!', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string[] commands = Console.ReadLine()
                .Split();

            while (commands[0] != "Go")
            {
                switch (commands[0])
                {
                    case "Urgent":         // Urgent {item}                       
                        if (shoppingList.Contains(commands[1]) == false)
                        {
                            shoppingList.Insert(0, commands[1]);
                        }

                        break;

                    case "Unnecessary":        // Unnecessary {item}
                        if (shoppingList.Contains(commands[1]))
                        {
                            shoppingList.Remove(commands[1]);                            
                        }
                        break;

                    case "Correct":             // Correct {oldItem} {newItem}

                        if (shoppingList.Contains(commands[1]))
                        {
                            int index = shoppingList.IndexOf(commands[1]);
                            shoppingList[index] = commands[2];
                        }

                        break;

                    case "Rearrange":

                        if (shoppingList.Contains(commands[1]))
                        {
                            shoppingList.Remove(commands[1]);
                            shoppingList.Add(commands[1]);
                        }
                        break;
                }
                commands = Console.ReadLine().Split();
            }
            Console.WriteLine(String.Join(", ", shoppingList));
        }
    }
}
