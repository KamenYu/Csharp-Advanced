using System;
using System.Collections.Generic;

namespace StrategyPattern.Strategies
{
    public class QuckSort : ISortingStrategy
    {
        public void Sort(List<int> collection)
        {
            Console.WriteLine("Quick sort");
        }
    }
}
