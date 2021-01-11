using System;
using System.Linq;

namespace _5.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(x => int.Parse(x))
               .ToArray();
            string command = Console.ReadLine();
            Action<string> modifyArray = arithmeticOperation =>
            {
                switch (arithmeticOperation)
                {
                    case "add":  nums = nums.Select(n => ++n).ToArray(); break;
                    case "multiply": nums = nums.Select(n => n *= 2).ToArray(); break;
                    case "subtract": nums = nums.Select(n => --n).ToArray(); break;
                    case "print": Console.WriteLine(string.Join(' ', nums)); break;
                }
            };

            while (command != "end")
            {
                modifyArray(command);
                command = Console.ReadLine();
            }            
        }
    }
}
