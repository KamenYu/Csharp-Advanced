using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // -2.5 - 3 times

            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> numsLog = new Dictionary<double, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (numsLog.ContainsKey(nums[i]) == false)
                {
                    numsLog.Add(nums[i], 0);
                }
                numsLog[nums[i]]++;
            }

            foreach (var num in numsLog)
            {
                Console.WriteLine("{0} - {1} times", num.Key, num.Value);
            }
        }
    }
}
