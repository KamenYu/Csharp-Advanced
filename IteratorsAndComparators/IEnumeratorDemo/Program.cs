using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumeratorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();

            //StringEnumerator enumerator = new StringEnumerator(array);
            //IEnumerator enumerator = array.GetEnumerator();


            List<int> nums = new List<int>() { 1, 2, 3, 4 };
            var enumerator = nums.GetEnumerator();
            // the foreach calls for the MoveNext and fires

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
                // the current element
            }

        }
    }
}
