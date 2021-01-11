using System;
using System.Linq;

namespace _3.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            Func<int[], int> minValue = GetMin;
            Console.WriteLine(minValue(nums));
        }

        public static int GetMin(int[] nums)
        {
            int min = int.MaxValue;

            foreach (var num in nums)
            {
                if (min > num)
                {
                    min = num;
                }
            }
            return min;
        }
    }
}
