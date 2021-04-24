using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using StrategyPattern.Strategies;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // adding a new functionality happens only in one place, thus O/C
            string sortType = Console.ReadLine();

            Type strategy = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(x => typeof(ISortingStrategy)
                .IsAssignableFrom(x) && x.Name.StartsWith(sortType))
                .FirstOrDefault();

            ISortingStrategy iStrategy = Activator
                .CreateInstance(strategy) as ISortingStrategy;

            Sorter s = new Sorter(iStrategy);
            s.Sort(new List<int>() { 5, 7, 99, 0, 62 });
        }
    }
}
