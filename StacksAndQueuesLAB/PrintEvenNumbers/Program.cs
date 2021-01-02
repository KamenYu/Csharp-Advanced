using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> even = new Queue<int>();
            foreach (var item in nums)
            {
                if (item % 2 == 0)
                {
                    even.Enqueue(item);
                }
            }
            Console.WriteLine(string.Join(", ", even));
        }
    }
}
