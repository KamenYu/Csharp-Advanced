using System;
using System.Linq;

namespace _5.FilterByAge
{
    class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Person[] people = new Person[n];

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(", ");
                people[i] = new Person()
                {
                    Name = info[0],
                    Age = int.Parse(info[1])
                };
            }

            string condition = Console.ReadLine(); // older OR younger
            int ageToFilter = int.Parse(Console.ReadLine());
            string format = Console.ReadLine(); // name, nage. name age

            Func<Person, bool> conditionDelegate = GetCondition(condition, ageToFilter); //2) create a delegate from the method
            Action<Person> formatDelegate = Printer(format);


            foreach (var person in people)
            {
                if (conditionDelegate(person))
                {
                    formatDelegate(person);
                }
            }
        }

        static Action<Person> Printer(string format)
        {
            switch (format)
            {
                case "name": return p =>
                {
                    Console.WriteLine($"{p.Name}");
                };

                case "age":
                    return p =>
                    {
                        Console.WriteLine($"{p.Age}");
                    };

                case "name age":
                    return p =>
                    {
                        Console.WriteLine($"{p.Name} - {p.Age}");
                    };
                default:
                    return null;
            }
        }

        static Func<Person, bool> GetCondition(string condition, int age) // 1) create a method that returns a func
        {
            switch (condition)
            {
                case "older": return p => p.Age >= age;
                case "younger": return p => p.Age < age;
                default:
                    return null;
            }
        }
    }
}
