using System;

namespace _4.ComparingObjects
{
    public class Person : IComparable<Person> // what are you going to compare!!
    {

        public Person(string name, int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Town { get; set; }

        public int CompareTo(Person other)
        {
            int res = Name.CompareTo(other.Name);

            if (res == 0)
            {
                res = Age.CompareTo(other.Age);

                if (res == 0)
                {
                    res = Town.CompareTo(other.Town);
                }
            }

            return res;
        }
    }
}
