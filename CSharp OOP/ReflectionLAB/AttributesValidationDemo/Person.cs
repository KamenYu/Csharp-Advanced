using System;
namespace AttributesValidationDemo
{
    public class Person
    {
        public Person()
        {
        }

        [Range(18, 65)]
        public int Age { get; set; }
    }
}
