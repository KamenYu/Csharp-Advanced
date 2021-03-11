using System;
using System.Collections.Generic;

namespace Sorter
{
    public class QuickSorter : ISortingStrategyPattern
    {
        public ICollection<int> Sort(ICollection<int> collection)
        {
            Console.WriteLine("Quick sort is quicker");
            return collection;
        }        
    }
}
