using System;
using System.Collections.Generic;

namespace _4.ComparingObjects
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            List<Person> people = new List<Person>();

            while (line != "END")
            {
                string[] tokens = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(tokens[0], int.Parse(tokens[1]), tokens[2]);
                people.Add(person);
                line = Console.ReadLine();
            }

            int n = int.Parse(Console.ReadLine()) - 1;

            Person personToCompare = people[n];

            int notEqual = 0;
            int equal = 0;

            foreach (var p in people)
            {
                if (personToCompare.CompareTo(p) == 0)
                {
                    equal++;
                }
                else
                {
                    notEqual++;
                }
            }

            if (equal == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equal} {notEqual} {people.Count}");
            }

        }
    }
}
