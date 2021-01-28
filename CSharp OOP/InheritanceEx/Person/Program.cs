using System;

namespace Person
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // if there is a condition that says a person cannot have a negative age, change the age in the prop in the setter
            // if there is a condition that says a child cannot be older than 14. change Person Age to virtual, then set the getter
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Person p;

            if (age > 15)
            {
                p = new Person(name, age);
            }
            else
            {
                p = new Child(name, age);
            }

            
            Console.WriteLine(p);
        }
    }
}
