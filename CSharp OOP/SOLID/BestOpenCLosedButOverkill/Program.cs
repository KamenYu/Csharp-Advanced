using System;
using System.Collections.Generic;

namespace BestOpenCLosedButOverkill
{
    class Program
    {
        static void Main(string[] args)
        {
            StrategyPatterSorter sorter = new StrategyPatterSorter();
            sorter.Sort(new List<int>(), Console.ReadLine());
        }
    }
}
