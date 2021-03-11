using System.Collections.Generic;

namespace Sorter
{
    public class StrategyPatternSorter // in here to add a new sorting algorithm a new class must be added inheriting ISortingStrPattern, and only adding an if in here
    {
        public ICollection<int> Sort
            (ICollection<int> collection, string algorithm)
        {
            ISortingStrategyPattern pattern = null;
            if (algorithm.ToLower() == "selection")
            {
                pattern = new SelectionSorter();
            }
            if (algorithm.ToLower() == "quick")
            {
                pattern = new QuickSorter();
            }
            if (algorithm.ToLower() == "merge") // modification added
            {
                pattern = new MergeSorter();
            }

            return pattern.Sort(collection);
        }
    }
}
