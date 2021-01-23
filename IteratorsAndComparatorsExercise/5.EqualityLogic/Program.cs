using System;
using System.Collections.Generic;

namespace _5.EqualityLogic
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<Person> sorSet = new SortedSet<Person>();
            // sortedset uses the compareTo from class person
            HashSet<Person> hashSet = new HashSet<Person>();
            // hash set compares by hash
            // override GetHashCode to give different has to unequal items in our logic
            // then override Equals, because is what the hasSet looks if two elements are equal

            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(personInfo[0], int.Parse(personInfo[1]));
                //Console.WriteLine(person.GetHashCode());
                sorSet.Add(person);
                hashSet.Add(person);
            }

            Console.WriteLine(sorSet.Count);
            Console.WriteLine(hashSet.Count);
        }
    }
}
