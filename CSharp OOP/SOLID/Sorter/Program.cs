using System;
using System.Collections.Generic;

namespace Sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            // by given input to use such algorithm for sorting
            // selection, merge, bubble, quick etc

            Sorter sorter = new Sorter();
            sorter.Sort(new List<int>(), Console.ReadLine());
        }
    }
}
