using System;
using System.Collections.Generic;

namespace CustomDataStructures
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 4, 6, 8, 10, 12 };
            Stack<int> stekche = new Stack<int>(array);
            stekche.Pop();
            Console.WriteLine(stekche.Peek());
            Console.WriteLine(string.Join(' ', stekche));

            CustomStack stack = new CustomStack();

            for (int i = 2; i <= 12; i+=2)
            {
                stack.Push(i);
            }

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            stack.ForEach(Console.WriteLine);

        }
    }
}
