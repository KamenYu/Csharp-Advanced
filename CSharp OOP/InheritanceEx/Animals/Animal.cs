using System;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        private string gender;
        private int age;

        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name { get; set; } // !!

        public int Age
        {   get { return age; }
            set
            {
                if (value <  0) // !! value !!
                {
                    throw new InvalidOperationException("Invalid input!");
                }

                age = value;
            }
        }

        public string Gender
        {
            get { return gender; }
            set
            {
                if (value != "Male" && value != "Female")
                {
                    throw new InvalidOperationException("Invalid input!");
                }

                gender = value;
            }
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{GetType().Name}");
            sb.AppendLine($"{Name} {Age} {Gender}");
            sb.AppendLine($"{ProduceSound()}");

            return sb.ToString().TrimEnd(); ;
        }
    }
}
