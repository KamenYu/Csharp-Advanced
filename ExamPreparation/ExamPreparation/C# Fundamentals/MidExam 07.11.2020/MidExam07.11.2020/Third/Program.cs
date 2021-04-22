using System;
using System.Linq;
using System.Collections.Generic;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> availableCards = Console.ReadLine()
                .Split(':')
                .ToList();

            List<string> myDeck = new List<string>();

            string[] cmd = Console.ReadLine().Split();

            while (cmd[0] != "Ready")
            {
                switch (cmd[0])
                {
                    case "Add":     // Add {card name}

                        if (!availableCards.Contains(cmd[1]))
                        {
                            Console.WriteLine("Card not found.");
                        }
                        else
                        {
                            myDeck.Add(cmd[1]);
                        }
                        break;

                    case "Insert":      // Insert {card name} {index}

                        int indexToInsert = int.Parse(cmd[2]);
                        bool inRange = indexToInsert >= 0 && indexToInsert <= myDeck.Count - 1;

                        if (availableCards.Contains(cmd[1]) && inRange)
                        {
                            myDeck.Insert(indexToInsert, cmd[1]);
                        }
                        else
                        {
                            Console.WriteLine("Error!");
                        }

                        break;

                    case "Remove":      // Remove {card name}

                        if (myDeck.Contains(cmd[1]))
                        {
                            myDeck.Remove(cmd[1]);
                        }
                        else
                        {
                            Console.WriteLine("Card not found.");
                        }

                        break;

                    case "Swap":        // Swap {card name 1} {card name 2}

                        int cardOneIndex = myDeck.IndexOf(cmd[1]);
                        int cardTwoIndex = myDeck.IndexOf(cmd[2]);

                        myDeck[cardOneIndex] = cmd[2];
                        myDeck[cardTwoIndex] = cmd[1];

                        break;

                    case "Shuffle":
                        myDeck.Reverse();
                        break;

                    default:
                        break;
                }

                cmd = Console.ReadLine().Split();
            }
            Console.WriteLine(String.Join(' ', myDeck));
        }
    }
}
