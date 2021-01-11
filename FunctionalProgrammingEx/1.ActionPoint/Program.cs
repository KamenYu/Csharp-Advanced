using System;

namespace _1.ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Action<string[]> print = PrintNames;
            print(names);
        }

        static void PrintNames(string[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
