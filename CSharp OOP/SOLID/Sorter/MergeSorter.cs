using System;
using System.Collections.Generic;

namespace Sorter
{
    public class MergeSorter : ISortingStrategyPattern
    {
        public ICollection<int> Sort(ICollection<int> collection)
        {
            Console.WriteLine("Merge sort is merging");
            return collection;
        }
    }
}
