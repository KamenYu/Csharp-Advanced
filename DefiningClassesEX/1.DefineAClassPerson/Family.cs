using System.Collections.Generic;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> People { get; set; } = new List<Person>();

        public void AddMember(Person member)
        {
            People.Add(member);
        }

        public Person GetOldestMember()
        {
            int maxAge = int.MinValue;
            string name = string.Empty;
            foreach (var person in People)
            {
                if (person.Age > maxAge )
                {
                    maxAge = person.Age;
                    name = person.Name;
                }
            }
            Person oldest = new Person(name, maxAge);
            return oldest;
        }
    }
}
