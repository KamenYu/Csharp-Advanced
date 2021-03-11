using System;
using System.Collections.Generic;

namespace BestOpenCLosedButOverkill
{
    public class MergeSort : ISortingStrategyPattern
    {
        public ICollection<int> Sort(ICollection<int> collection)
        {
            Console.WriteLine("Meeeeeeerge");
            return collection;
        }
    }
}
