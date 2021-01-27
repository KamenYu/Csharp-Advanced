using System;
namespace InheritanceDemo
{
    public class Person
    {
        public Person()
        {
            Console.WriteLine("In the person constructor");
        }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}
