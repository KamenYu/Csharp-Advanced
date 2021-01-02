using System;
using System.Linq;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long[][] pascal = new long[n][];
            long cols = 1;
            for (int row = 0; row < pascal.Length; row++)
            {
                pascal[row] = new long[cols];
                pascal[row][0] = 1;
                pascal[row][pascal[row].Length - 1] = 1;

                if (row > 1)
                {
                    for (int col = 1; col < pascal[row].Length - 1; col++)
                    {
                        long[] previous = pascal[row - 1];
                        long f = previous[col];
                        long s = previous[col - 1];
                        pascal[row][col] = f + s;
                    }
                }
                cols++;                
            }

            foreach (var item in pascal)
            {
                Console.WriteLine(string.Join(' ', item));
            }
        }
    }
}
