using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> sorted = MergeSort(array);

            Console.WriteLine(string.Join(" ", sorted));
        }

        private static List<int> MergeSort(List<int> list)
        {
            if (list.Count <= 1)
            {
                return list;
            }
            int middle = list.Count / 2;

            List<int> left = MergeSort(list.GetRange(0, middle));
            List<int> right = MergeSort(list.GetRange(middle, list.Count - middle));

            return Combined(left, right);
        }

        private static List<int> Combined(List<int> left, List<int> right)
        {
            List<int> combined = new List<int>();
            int leftIndex = 0;
            int rightIndex = 0;

            while (leftIndex < left.Count && rightIndex < right.Count)
            {
                if (left[leftIndex] < right[rightIndex])
                {
                    combined.Add(left[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    combined.Add(right[rightIndex]);
                    rightIndex++;
                }
            }

            for (int i = leftIndex; i < left.Count; i++)
            {
                combined.Add(left[i]);
            }

            for (int i = rightIndex; i < right.Count; i++)
            {
                combined.Add(right[i]);
            }

            return combined;
        }
    }
}
