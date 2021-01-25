using System;
using System.Linq;

namespace BinarySearch
{
    class Program
    {
        //static int count = 0;
        static void Main(string[] args)
        {
            //int[] array = new int[]
            //    {4,6, 9, 29, 88, 190, 438, 567, 569, 601};

            //int[] array = new int[1000000];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = i;
            //}

            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(BinarySearch(array, n, 0, array.Length));
            //Console.WriteLine(count);
        }

        private static int BinarySearch(int[] array, int n, int start, int end)
        {
            if (start > end)
            {
                return -1;
            }

            //count++;
            int middle = (start + end) / 2;

            if (n < array[middle])
            {
                return BinarySearch(array, n, start, middle - 1);
            }

            if (n > array[middle])
            {
                return BinarySearch(array, n, middle + 1, end);
            }
            else
            {
                return middle;
            }
        }
    }
}
