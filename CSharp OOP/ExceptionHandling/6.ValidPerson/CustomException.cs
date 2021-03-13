using System;
namespace _6.ValidPerson
{
    public class MyInvalidPersonNameException : Exception
    {
        public MyInvalidPersonNameException()
        {

        }

        public MyInvalidPersonNameException(string name, string message)
            : base(message)
        {
            Name = name;
        }

        public override string Message => "A name cannot consist of numbers.";
        public string Name { get; }      
    }
}
