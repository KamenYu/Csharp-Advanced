using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reverses a collection and removes elements that are divisible by a given integer n

            List<int> list = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToList();

            int n = int.Parse(Console.ReadLine());

            Func<List<int>, int, List<int>> numSelection = NumSelection;// this can happend with linq and where as well
            Console.WriteLine(string.Join(' ', numSelection(list, n)));
        }

        private static List<int> NumSelection(List<int> nums, int n)
        {
            List<int> modified = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % n != 0)
                {
                    modified.Add(nums[i]);
                }
            }
            return modified;
        }
    }
}
