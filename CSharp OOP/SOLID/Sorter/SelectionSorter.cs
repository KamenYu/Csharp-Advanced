using System;
using System.Collections.Generic;

namespace Sorter
{
    public class SelectionSorter : ISortingStrategyPattern
    {
        public ICollection<int> Sort(ICollection<int> collection)
        {
            Console.WriteLine("Selection sort");
            return collection;
        }
    }
}
