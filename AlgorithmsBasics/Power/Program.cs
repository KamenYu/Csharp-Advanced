using System;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            //int res = 1;
            //for (int i = 0; i < n; i++)
            //{
            //    res *= x;
            //}

            //Console.WriteLine(res);

            Console.WriteLine(Power(x, n));
        }

        static int Power(int x, int n)
        {
            if (n == 1)
            {
                return x;
            }

            Console.WriteLine("Before Recursion");
            int current = x * Power(x, n - 1);
            Console.WriteLine("After Recursion");
            return current;        
        }
    }
}
