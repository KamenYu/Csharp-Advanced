using System;
using System.Linq;

namespace _12.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Func<string, int> asciiSumPerName = n => n.Select(c => (int)c).Sum();

            Func<string[], int, Func<string, int>, string> nameFunc = (names, n, func)
                 => names.FirstOrDefault(p => func(p) >= n);
            Console.WriteLine(nameFunc(names, n, asciiSumPerName));
        }
    }
}
