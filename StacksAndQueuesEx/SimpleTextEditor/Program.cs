using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string text = string.Empty;
            
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "1":
                        stack.Push(text);
                        text += command[1];
                        break;

                    case "2":
                        stack.Push(text);                      
                        int count = int.Parse(command[1]);
                        text = text.Substring(0, text.Length - count);
                        break;

                    case "3":
                        Console.WriteLine(text[int.Parse(command[1]) - 1]);                       
                        break;

                    case "4":
                        text = stack.Pop();
                        break;
                }
            }
        }
    }
}
