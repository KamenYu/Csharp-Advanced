using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] expression = Console.ReadLine().Split().Reverse().ToArray();
            Stack<string> stack = new Stack<string>(expression);

            while (stack.Count > 1)
            {
                int f = int.Parse(stack.Pop());
                string sign = stack.Pop();
                int s = int.Parse(stack.Pop());

                if (sign == "+")
                {
                    stack.Push((f + s).ToString());
                }
                else
                {
                    stack.Push((f - s).ToString());
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
