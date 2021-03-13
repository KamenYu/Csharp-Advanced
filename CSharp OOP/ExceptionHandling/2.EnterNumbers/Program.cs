using System;
using System.Collections.Generic;

namespace _2.EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
             ReadNumber(1, 100);
        }

        private static void ReadNumber(int start, int end)
        {
            int counter = 0;
            Stack<int> stack = new Stack<int>(10);
            stack.Push(1);

            while (counter != 5)
            {
                try
                {                    
                    Console.WriteLine("Write a number:");
                    int f = int.Parse(Console.ReadLine());

                    if (stack.Peek() <= f)
                    {
                        stack.Pop();
                        stack.Push(f);
                    }
                    else if (stack.Peek() > f)
                    {
                        stack.Clear();
                        stack.Push(1);
                        throw new ArithmeticException();
                    }

                    Console.WriteLine("Write a bigger number");
                    int s = int.Parse(Console.ReadLine());

                    if (s <= f || s < 0 || stack.Peek() > f || f < 0)
                    {
                        stack.Clear();
                        stack.Push(1);
                        throw new ArithmeticException();
                    }
                    
                    stack.Push(s);
                    counter++;
                }
                catch (FormatException fe)
                {
                    counter = 0;
                    Console.WriteLine("Invalid input for number");
                }
                catch (ArithmeticException ae)
                {
                    counter = 0;
                    Console.WriteLine("Invalid number. Next number should be always bigger than the previous.");
                }               
            }
            Console.WriteLine("Success you typed 10 numbers in increasing order");
        }
    }
}
