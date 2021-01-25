using System;

namespace RecursionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // iteratively
            for (int i = 0; i < 3; i++)
            {
                //Console.WriteLine("Something");
            }

            // recursion
            Loop(3);
        }

        private static void Loop(int n)
        {
            if (n == 0)
            {
                return;
            }

            Console.WriteLine("Recursion Something");
            Loop(n - 1);
        }
    }
}
