using System;
using System.Linq;
using System.Collections.Generic;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            List<int> best5 = new List<int>();
            
            double arrayAverage = array.Sum() * 1.0 / array.Length;         

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > arrayAverage)
                {
                    best5.Add(array[i]);
                }
            }
            best5.Sort();
            best5.Reverse();

            if (best5.Count > 5)
            {
                int index = best5.IndexOf(best5[5]);
                best5.RemoveRange(index, best5.Count - 5);
                Console.WriteLine(String.Join(" ", best5));
            }
            else if (best5.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(String.Join(" ", best5));
            }
            
        }
    }
}
