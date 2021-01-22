using System;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book> // IComparable<int>,
    {
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = authors.ToList();
        }

        public string Title { get; set; }

        public int Year { get; set; }

        public List<string> Authors { get; set; }

        //public int CompareTo(int other) // you make your custom CompareTo() && can be used for sorting
        //{
        //    // CompareTo(int other) to compare book years with any int
        //    if (Year < other)
        //    {
        //        return -1;
        //    }
        //    else if (Year == other)
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        return 1;
        //    }
        //    // in this way we sort ascending
        //}

        public int CompareTo(Book other)
        {
            int res = Year.CompareTo(other.Year);

            if (res == 0)
            {
                res = Title.CompareTo(other.Title);
            }

            return res;
        }

        //public int CompareTo(Book other)
        //{
        //    //// CompareTo(Book other) to compare book.year with any other.year
        //    if (Year > other.Year)
        //    {
        //        return -1;
        //    }
        //    else if (Year == other.Year)
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        return 1;
        //    }
        //    // this is descending order
        //}

        //public int CompareTo(Book other)
        //{

        //    if (Title[0] < other.Title[0])
        //    {
        //        return -1;
        //    }
        //    else if (Title[0] == other.Title[0])
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        return 1;
        //    }
        //}

        public override string ToString()
        {
            return $"{Title} - {Year}";
        }

    }
}
