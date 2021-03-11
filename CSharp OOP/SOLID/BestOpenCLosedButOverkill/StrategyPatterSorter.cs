using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace BestOpenCLosedButOverkill
{
    public class StrategyPatterSorter // here only class must be created and everything works
    { // it is the best option, but reflection makes things slower
        private ICollection<int> collection = new List<int>();
        public ICollection<int> Sort
            (ICollection<int> collection, string algorithm)
        {
            
            //var allTypes = Assembly
            //    .GetExecutingAssembly()
            //    .GetTypes()
            //    .ToList(); // all classes in the assembly

            var sorterType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(t => typeof(ISortingStrategyPattern).IsAssignableFrom(t) && t.IsClass)
                .FirstOrDefault( t => t.Name.ToLower().Contains(algorithm));


            ISortingStrategyPattern pattern = (ISortingStrategyPattern)Activator.CreateInstance(sorterType);

            return pattern.Sort(collection);
        }
    }
}
