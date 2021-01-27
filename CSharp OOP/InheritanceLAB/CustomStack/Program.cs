using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();
            Stack<string> sStack = new Stack<string>();

            for (int i = 1; i <= 5; i++)
            {
                sStack.Push($"{i}");
            }
            Console.WriteLine(stack.IsEmpty());
            stack.Push("0");
            stack.AddRange(sStack);
            Console.WriteLine(stack.Count);
            
        }
    }
}
