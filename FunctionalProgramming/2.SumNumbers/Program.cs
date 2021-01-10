using System;
using System.Linq;

namespace _2.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(", ")
                .Select(x => int.Parse(x))
                .ToArray();

            Func<int[], int> count = GetCount; // delegate
            Func<int[], int> sum = SumOfAllElements;
            Console.WriteLine(count(nums));
            Console.WriteLine(sum(nums));
        }

        static int GetCount(int[] array)
        {
            return array.Length;
        }

        static int SumOfAllElements(int[] array)
        {
            return array.Sum();
        }
    }
}
