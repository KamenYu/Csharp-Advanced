using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Demo1
{
    class Program
    {
        // Activator.CreateInstance
        static void Main(string[] args)
        {
            //Console.WriteLine(new string ('-', 35));
            //Console.WriteLine(new string ('~', 30));

            Type type = typeof(Person);
            Person p = new Person();
            var per = Activator.CreateInstance(type) as Person; // returns object
            // use "as" because when impossible to cast returns null, the usual casting throws InvalidCastingException
            per.Age = 20;
            Console.WriteLine(type);// where is Person placed in my assebly - Demo1.Person
            Console.WriteLine(type.FullName); // same as above -||-
            Console.WriteLine(type.Name); // Person
            Console.WriteLine(type.BaseType); // if Person does not inherit anything - System.Object
            // if it inherits something else, BaseType is not System.Object, but one step above
             //Type type = typeof(Person); here I cannot take the prop name, or prop value
            var result = (int)type.GetProperty("Age").GetValue(per);
            // GetValue needs an instance of the class to take the value of the property
            // GetValue returns an object

            string propName = type.GetProperty("Age").Name;

            Console.WriteLine(result);

            Console.WriteLine(new string('~', 45));

            var instanceOfSB = Activator.CreateInstance(typeof(StringBuilder)) as StringBuilder;
            var instanceOfList = Activator.CreateInstance(typeof(List<string>)) as List<string>;
            
            instanceOfSB.AppendLine("Why ice cream is so good?");
            instanceOfSB.AppendLine("Cuz, I like to scream and you like to scream.");
            
            Console.WriteLine(instanceOfSB.ToString().Trim());

            Console.WriteLine(new string('~', 45));

            var personK = Activator.CreateInstance(typeof(Person), "Kamen", 12) as Person;
            Console.WriteLine($"{personK.Name } is { personK.Age} years old");

            personK.GetType().GetProperty("Age").SetValue(personK, 17); // GetType gives me reflection methods
            per.GetType().GetProperty("Age").GetValue(personK);
            // get && set value are for the current instances - personK and per
            //while GetProp is only for the class
            Console.WriteLine(new string('~', 45));

            // if I want to create instances given from the console without using "new" and "if/else" do this:
            string instanceS = Console.ReadLine();

            Type currentType = Assembly.GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(n => n.Name == instanceS);

            var instance = currentType != null ? Activator.CreateInstance(currentType)
                : throw new InvalidOperationException("The issued type does not exist in this assembly.");

            Console.WriteLine(new string('~', 45));

            var personP = typeof(Person);
            Console.WriteLine(personP.GetProperty("Name").Name);// GetProp takes only the public props
            //..WriteLine(personP.GetField("name").Name); this will not work, to get any field you need to use BindingFlags
            //to describe the access modifiers of the field
            // because fields can be private or public or static or instance.

            Console.WriteLine(personP.GetField("name", BindingFlags.Instance
                | BindingFlags.Public | BindingFlags.NonPublic
                | BindingFlags.Static).Name);

            foreach (var item in personP.GetFields(BindingFlags.Instance
                | BindingFlags.Public
                | BindingFlags.NonPublic
                | BindingFlags.Static)) // takes all fields
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine(new string('~', 45));

            ConstructorInfo[] personCtor = typeof(Person)
                .GetConstructors(BindingFlags.NonPublic
                | BindingFlags.Static
                | BindingFlags.Instance
                | BindingFlags.Public); //without bingingFlags takes only the public ones

            ConstructorInfo personCtorInstance = typeof(Person)
               .GetConstructor(new Type[] { typeof(string) });
            Console.WriteLine(personCtor.Length); // how many ctors are there
            // even if the class is empty the output will be 1
            // because there is an invisible empty ctor for every empty class            

            Person pe = personCtorInstance.Invoke(new object[] { "Kamen" }) as Person;
            // this is the ugly way of creating an instance, but happens
            // because sometimes you need to take the ctors first
            Console.WriteLine($"{pe.Name} lives in {pe.address} and is {pe.Age} old");

            Console.WriteLine(new string('~', 45));

            var personMethods = typeof(Person)
                .GetMethods();

            var personMethod = typeof(Person)
                .GetMethod("ReverseName");
            Console.WriteLine(personMethod.ReturnType);
            var res = personMethod.Invoke(personK, new object[] { }); // Invoke summons the method
            Console.WriteLine(res);
            foreach (var item in personMethods)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine(new string('~', 45));

            // types of Assembly

            // * GetExecutingAssembly - where my code is executing
            // ** GetCallingAssembly - from which assembly was my code called
            // *** GetEntryAssembly - from where the program has started
        }
    }
}
