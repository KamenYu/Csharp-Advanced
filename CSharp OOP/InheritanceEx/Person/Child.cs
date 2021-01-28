using System;
namespace Person
{
    public class Child : Person
    {
        public Child(string name, int age)
            : base(name, age)
        {
        }

        public override int Age
        {
            get
            {
                return base.Age;
            }
            set
            {
                if (value > 15)
                {
                    throw new ArgumentException("A child must be 14 or less");
                }

                base.Age = value;
            }
        }
    }
}
