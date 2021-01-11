using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int upperLimit = int.Parse(Console.ReadLine());
            List<int> list = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Distinct()
                .ToList();
            HashSet<int> nums = new HashSet<int>();

            for (int i = 1; i <= upperLimit; i++)
            {
                bool isValid = true;

                foreach (int item in list)
                {
                    Func<int, int, bool> selection = (i, item) =>
                    {
                        return i % item == 0;
                    };

                    if (selection(i, item) == false)
                    {
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    nums.Add(i);
                }
            }
            Console.WriteLine(string.Join(' ', nums)) ;
        }
    }
}
