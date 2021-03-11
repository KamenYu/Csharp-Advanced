using System;
using System.Collections.Generic;

namespace Sorter
{
    public class Sorter // this class made like that does not follow O/C, thus it is open for modification, solution to this is STRATEGY PATTERN
    {// in this case ISortingStrategyPattern
        public ICollection<int> Sort
            (ICollection<int> collection, string algorithm)
        {
            if (algorithm.ToLower() == "selection")
            {
                return SelectionSort(collection);

            }
            else if (algorithm.ToLower() == "quick")
            {
                return QuickSort(collection);
            }
            else if (algorithm.ToLower() == "merge") // modification added
            {
                return MergeSort(collection);
            }

            throw new ArgumentException("Sorter does not exist!");
        }

        ICollection<int> SelectionSort(ICollection<int> collection)
        {
            Console.WriteLine("Selection sort");
            return collection;
        }

        ICollection<int> QuickSort(ICollection<int> collection)
        {
            Console.WriteLine("Quick sort is quicker");
            return collection;
        }

        ICollection<int> MergeSort(ICollection<int> collection) // modification added
        {
            Console.WriteLine("Merge sort is merging");
            return collection;
        }
    }
}
