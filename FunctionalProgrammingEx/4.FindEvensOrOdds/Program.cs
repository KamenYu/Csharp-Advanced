using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are given a lower and an upper bound for a range of integer numbers.
            //Then a command specifies if you need to list all even or odd numbers in the given range.

            int[] bounds = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray(); // 1 - 10 || 10 - 1 

            string command = Console.ReadLine();

            Func<int[], List<int>> createListDelegate = CreateList;
            //Func<List<int>, string, List<int>> finderDelegate = Finder;
            List<int> list = createListDelegate(bounds);
            Predicate<int> predicate = n => n % 2 == 0;

            if (command == "odd")
            {
                predicate = n => n % 2 != 0;
            }

            list = MyWhere(list, predicate);
            Console.WriteLine(string.Join(' ', list));
        }

        private static List<int> MyWhere(List<int> list, Predicate<int> predicate)
        {
            List<int> modified = new List<int>();
            foreach (var li in list)
            {
                if (predicate(li))
                {
                    modified.Add(li);
                }
            }
            return modified;
        }

        private static List<int> CreateList(int[] bounds)
        {
            List<int> list = new List<int>();
            for (int i = bounds[0]; i <= bounds[1]; i++)
            {
                list.Add(i);
            }
            return list;
        }

        public static List<int> Finder(List<int> nums, string command)
        {
            List<int> modified = new List<int>();
            switch (command)
            {
                case "even":
                    foreach (var item in nums)
                    {
                        if (item % 2 == 0)
                        {
                            modified.Add(item);
                        }
                    }
                    break;
                case "odd":
                    foreach (var item in nums)
                    {
                        if (item % 2 != 0)
                        {
                            modified.Add(item);
                        }
                    }
                    break;
                default:
                    return null;
            }
            return modified;
        }
    }
}
