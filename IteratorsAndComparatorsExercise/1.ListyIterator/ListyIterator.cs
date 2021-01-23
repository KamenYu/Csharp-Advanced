using System;
using System.Collections;
using System.Collections.Generic;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private int index;
        private List<T> collection { get; set; }

        public ListyIterator(List<T> list)
        {
            index = 0;
            collection = list;
        }

        public int Count => collection.Count;

        public bool Move()
        {
            if (HasNext())
            {
                index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (index < Count - 1)
            {
                return true;
            }
            return false;
        }

        public void Print()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(collection[index]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            int temp = index;
            index = 0;

            while (index < Count)
            {               
                yield return collection[index];
                if (Move() == false)
                {
                    index = temp;
                    yield break;
                }
            }

            //foreach (T item in collection)
            //{
            //    yield return item;
            //}
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
