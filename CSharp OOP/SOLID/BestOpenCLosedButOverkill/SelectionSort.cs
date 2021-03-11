using System;
using System.Collections.Generic;

namespace BestOpenCLosedButOverkill
{
    public class SelectionSort : ISortingStrategyPattern
    {
        public ICollection<int> Sort(ICollection<int> collection)
        {
            Console.WriteLine("Selection sort");
            return collection;
        }
    }
}