using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // print all people whose age is more than 30 years, sorted alphabetically 
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] nameAndAge = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Person member = new Person(nameAndAge[0], int.Parse(nameAndAge[1]));
                people.Add(member);
            }
            people = people.Where(x => x.Age > 30).ToList();

            foreach (Person person in people.OrderBy(x => x.Name))
            {
                Console.WriteLine("{0} - {1}", person.Name, person.Age);
            }
        }
    }
}
