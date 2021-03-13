using System;
using System.Collections.Generic;
using System.Reflection;

namespace ReflectionAttributesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var attrs = typeof(Person)
                //.GetProperty("Age") this takes only the attributes of the searched prop
                .GetCustomAttributes(); // only this takes only the attr above the class


            foreach (var item in attrs)
            {
                Console.WriteLine(item.GetType().Name);
                Console.WriteLine(item.TypeId); // where it is
                Console.WriteLine(((AuthorAttribute)item).Name); // what is the info inside the attribute
            }

            Console.WriteLine(new string('-', 60));

            Type[] allTypes = Assembly.GetExecutingAssembly()
                .GetTypes();

            foreach (var item in allTypes)
            {
                IEnumerable<Attribute> attributes = item.GetCustomAttributes(typeof(AuthorAttribute));

                foreach (var attr in attributes)
                {
                    Console.WriteLine(item.Name + " - " + ((AuthorAttribute)attr).Name);
                }
            }
        }

        [Flags] // allows enums to be treated as bits
        public enum FileAccess
        {
            Read = 1,
            Write = 2,
            Both = Read | Write
        }
    }
}
