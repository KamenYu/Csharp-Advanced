using System;
using System.Collections.Generic;

namespace BestOpenCLosedButOverkill
{
    public class QuickSort : ISortingStrategyPattern
    {
        public ICollection<int> Sort(ICollection<int> collection)
        {
            Console.WriteLine("Quick sort is quicker");
            return collection;
        }
    }
}
