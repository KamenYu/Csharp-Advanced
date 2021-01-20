using System;
using System.Collections.Generic;

namespace GenericCountMethodStringAndDouble
{
    public class Box<T> where T : IComparable
    {
        public List<T> List { get; set; } = new List<T>();

        public T Element { get; set; }

        public Box(List<T> input, T element)
        {
            List = input;
            Element = element;
        }

        public int CountOfElementsBiggerThanInput()
        {
            int count = 0;

            foreach (var item in List)
            {
                if (item.CompareTo(Element) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
