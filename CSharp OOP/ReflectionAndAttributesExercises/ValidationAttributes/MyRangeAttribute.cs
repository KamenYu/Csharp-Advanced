using System;

namespace ValidationAttributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private int min;
        private int max;

        public MyRangeAttribute(int min, int max)
        {
            this.min = min;
            this.max = max;
        }

        public override bool IsValid(object obj)
        {
            if ((obj is int) == false)
            {
                throw new ArgumentException("Age should be an integer");
            }

            return (int)obj >= min && (int)obj <= max;
        }
    }
}