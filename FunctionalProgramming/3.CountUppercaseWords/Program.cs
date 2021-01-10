using System;
using System.Linq;

namespace _3.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> checker = x => x[0] == x.ToUpper()[0];
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(checker)
                .ToArray();

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
