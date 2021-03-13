using System.Linq;

namespace Demo1
{
    public class Person : Human
    {
        private static int age; // static and nonpublic field
        private string name; // instance and nonpublic field
        public string address; // instance and public field

        public Person(string name)
        {
            Name = name;
        }

        //private Person(int age)
        //{
        //    Age = age;
        //}

        //static Person()
        //{
        //}

        //protected Person(string name, int age)
        //{
        //    Name = name;
        //    Age = age;
        //}

        public Person(int age)
        {
            Age = age;
        }

        public Person()
        {
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }


        public int AfterHundredYears()
        {
            return Age + 100;
        }

        public string ReverseName()
        {
            char[] array = Name.ToCharArray();
            string reversed = "";

            for (int i = array.Length - 1; i >= 0; i--)
            {
                reversed += array[i];
            }

            return reversed;
        }
    }
}
