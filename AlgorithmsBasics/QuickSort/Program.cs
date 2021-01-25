using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] sorted = QuickSort(array);

            Console.WriteLine(string.Join(" ", sorted));

        }

        static int[] QuickSort(int[] array)
        {
            if (array.Length == 0)
            {
                return new int[0];
            }

            int pivot = array[0];
            List<int> leftArray = new List<int>();
            List<int> rightArray = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < pivot)
                {
                    leftArray.Add(array[i]);
                }

                if (array[i] > pivot)
                {
                    rightArray.Add(array[i]);
                }
            }

            return QuickSort(leftArray.ToArray()).Concat(new int[] { pivot }).Concat(QuickSort(rightArray.ToArray())).ToArray();
        }
    }
}
