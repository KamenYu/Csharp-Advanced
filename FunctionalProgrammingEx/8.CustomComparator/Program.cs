using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6 2 5 8 7 1 3 4
            // 2 4 6 8 1 3 5 7 first sort the evens then the odds

            Predicate<int> selectionE = n => n % 2 == 0;
            Predicate<int> selectionO = n => n % 2 != 0;

            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Func<int[], Predicate<int>, List<int>> func = EvenOROdd;

            List<int> listEven = func(array, selectionE);
            List<int> listOdd = func(array, selectionO);
            listEven.Sort();
            listOdd.Sort();

            int count = listOdd.Count;
            for (int i = 0; i < count ; i++)
            {
                listEven.Add(listOdd[i]);
            }
            Console.WriteLine(string.Join(' ', listEven));

        }

        private static List<int> EvenOROdd(int[] array, Predicate<int> predicate)
        {
            List<int> nums = new List<int>();
            foreach (var item in array)
            {
                if (predicate(item))
                {
                    nums.Add(item);
                }
            }
            return nums;
        }
    }
}
