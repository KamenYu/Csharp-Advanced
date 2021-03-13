using System;

namespace AttributesValidationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person { Age = 34 };

            bool isValid = Validator.Validate(p);

            Console.WriteLine(isValid);
        }
    }
}
