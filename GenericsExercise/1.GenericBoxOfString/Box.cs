using System;
namespace _1.GenericBoxOfString
{
    public class Box<T>
    {
        public T Input { get; set; }

        public Box(T input)
        {
            Input = input;
        }

        public override string ToString()
        {
            return $"{Input.GetType()}: {Input}";
        }
    }
}
