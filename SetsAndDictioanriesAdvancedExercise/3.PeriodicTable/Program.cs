using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> elements = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] element = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < element.Length; j++)
                {
                    elements.Add(element[j]);
                }
            }
            Console.WriteLine(string.Join(' ', elements.OrderBy(x => x)));
        }
    }
}
