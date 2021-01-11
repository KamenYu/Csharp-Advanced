using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty
{
    class Program
    {      
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            string command;

            while ((command = Console.ReadLine()) != "Party!")
            {
                string command1 = command.Split()[0];
                string command2 = command.Split()[1];
                string action = command.Split()[2];

                var predicate = GetPredicate(command2, action);

                switch (command1)
                {
                    case "Remove": names.RemoveAll(predicate); break; // if zero
                    case "Double":
                        List<string> matches = names.FindAll(predicate);

                        if (matches.Count > 0)
                        {
                            int indexToInsert = names.FindIndex(predicate);
                            names.InsertRange(indexToInsert, matches);
                        }

                        break;
                    default: break;
                }
            }

            if (names.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            }

        }

        public static Predicate<string> GetPredicate(string command2, string action)
        {
            switch (command2)
            {
                case "StartsWith": return n => n.StartsWith(action);
                case "EndsWith":   return n => n.EndsWith(action);
                case "Length":     return n => n.Length == int.Parse(action);
                default: return null;
            } 
        }
    }
}
