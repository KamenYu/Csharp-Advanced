using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace IteratorsAndComparators
{
    public class BookComparator : IComparer<Book>
    {
        public BookComparator()
        {
        }

        public int Compare( Book x,  Book y)
        {
            int res = x.Title.CompareTo(y.Title);

            if (res == 0)
            {
                res = y.Year.CompareTo(x.Year);
            }

            return res;
        }
    }
}
