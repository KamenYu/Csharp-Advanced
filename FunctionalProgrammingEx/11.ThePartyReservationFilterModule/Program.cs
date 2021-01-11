using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.ThePartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> listOFCommands = new List<string>();

            string command;

            while ((command = Console.ReadLine()) != "Print")
            {
                string[] tokens = command.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                // Add filter;Starts with;P
                if (tokens[0] == "Add filter")
                {
                    listOFCommands.Add($"{tokens[1]} {tokens[2]}");
                }
                else
                {
                    listOFCommands.Remove($"{tokens[1]} {tokens[2]}");
                }
            }

            foreach (var item in listOFCommands)
            {
                string[] selectionCommand = item.Split();

                switch (selectionCommand[0])
                {
                    case "Starts":
                        names = names.Where(n => !n.StartsWith(selectionCommand[2])).ToList();
                        break;
                    case "Ends":
                        names = names.Where(n => !n.EndsWith(selectionCommand[2])).ToList();
                        break;
                    case "Length":
                        names = names.Where(n => n.Length != int.Parse(selectionCommand[1])).ToList();
                        break;
                    case "Contains":
                        names = names.Where(n => !n.Contains(selectionCommand[1])).ToList();
                        break;
                }
            }
            Console.WriteLine(string.Join(' ', names));
        }
    }
}