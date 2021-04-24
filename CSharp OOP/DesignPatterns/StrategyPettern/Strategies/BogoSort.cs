using System;
using System.Collections.Generic;

namespace StrategyPattern.Strategies
{
    public class BogoSort : ISortingStrategy
    {

        public void Sort(List<int> collection)
        {
            Console.WriteLine("Bogo sort");
        }
    }
}
