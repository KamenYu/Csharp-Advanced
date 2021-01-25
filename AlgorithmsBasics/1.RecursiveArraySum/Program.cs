using System;
using System.Linq;

namespace _1.RecursiveArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse).ToArray();

            Console.WriteLine(Sum(array, 0));
        }

        private static int Sum(int[] array, int n)
        {
            if (n == array.Length)
            {
                return 0;
            }

            int res = array[n] + Sum(array, n + 1);
            return res;
        }
    }
}
