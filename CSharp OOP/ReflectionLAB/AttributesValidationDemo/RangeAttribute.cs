using System;
namespace AttributesValidationDemo
{
    public class RangeAttribute : Attribute
    {
        public RangeAttribute(int min, int max)
        {
            Min = min;
            Max = max;
        }

        public int Min { get; set; }
        public int Max { get; set; }

        public bool IsValid(int number)
        {
            return number >= Min && number <= Max;
        }
    }
}
