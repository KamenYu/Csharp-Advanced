using System;
using System.Linq;

namespace _1.SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(", ")
                .Select(x => int.Parse(x)).Where(n => n % 2 == 0).OrderBy(x => x)
                .ToArray();
            Console.WriteLine(string.Join(", ", nums));
        }
    }
}
