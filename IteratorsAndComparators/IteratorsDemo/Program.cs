using System;
using System.Collections.Generic;

namespace IteratorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            // list has GetEnumerator()

            foreach (var item in new Game()) // because Game() uses IEnumerable
            {

            }
        }
    }
}
