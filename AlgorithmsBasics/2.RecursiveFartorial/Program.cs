using System;

namespace _2.RecursiveFartorial
{
    class Program
    { 
        // this is for exercise purpose only
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(RecursiveFact(n));
        }

        public static long RecursiveFact(int n)
        {
            if (n == 1)
            {
                return n;
            }

            long res = n * RecursiveFact(n - 1);
            return res;
        }
    }
}
