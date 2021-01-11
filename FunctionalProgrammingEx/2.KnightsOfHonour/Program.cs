using System;

namespace _2.KnightsOfHonour
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Action<string[]> appendAndPrintDelegate = AppendAndPrint;
            appendAndPrintDelegate(names);
        }

        private static void AppendAndPrint(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = $"Sir {names[i]}";
                Console.WriteLine(names[i]);
            }
        }
    }
}
