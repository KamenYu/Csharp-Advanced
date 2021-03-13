using System;
using System.Diagnostics;
namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N");
            int a = 5;
            Console.WriteLine(a);
            int b = 6 * a;
            Console.WriteLine(b);
            double c = a - b * 0.5;
            Console.WriteLine(c);
            Console.WriteLine("K");
            //Debug.Assert(a == b);
            //Debug.WriteLine("Hello from degub WriteLine");


        }
    }
}
