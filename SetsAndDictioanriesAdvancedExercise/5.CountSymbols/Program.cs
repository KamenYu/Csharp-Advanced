using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> elLog = new Dictionary<char, int>();
            char[] line = Console.ReadLine().ToCharArray();

            for (int i = 0; i < line.Length; i++)
            {
                if (elLog.ContainsKey(line[i]) == false)
                {
                    elLog.Add(line[i], 1);
                }
                else
                {
                    elLog[line[i]]++;
                }
            }

            foreach (var el in elLog.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{el.Key}: {el.Value} time/s");
            }
        }
    }
}
