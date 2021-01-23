using System;
namespace _5.EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public override bool Equals(object obj)
        {
            if (GetHashCode() == obj.GetHashCode())
            {
                return true;
            }

            return false;           
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Age.GetHashCode();
        }

        public int CompareTo(Person other)
        {
            int res = Name.CompareTo(other.Name);

            if (res == 0)
            {
                res = Age.CompareTo(other.Age);
            }

            return res;
        }
    }
}
