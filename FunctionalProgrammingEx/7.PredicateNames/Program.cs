using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.PredicateNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(l => l.Length <= n)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, list));
        }
    }
}
