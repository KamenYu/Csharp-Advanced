using System;
using System.Collections.Generic;

namespace BalancedBracketsMINE
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] par = Console.ReadLine().ToCharArray();
            Stack<char> stack = new Stack<char>();
            // ()[({}[]]) -> NO
            // (){[]}     -> YES
            for (int i = 0; i < par.Length; i++)
            {
                bool  isOpen = par[i] == '(' || par[i] == '[' || par[i] == '{';

                if (isOpen)
                {
                    stack.Push(par[i]);
                }
                else
                {
                    if (stack.Count > 0)
                    {
                        bool isRound =  stack.Peek() == '(' && par[i] == ')';
                        bool isSquare = stack.Peek() == '[' && par[i] == ']';
                        bool isCurly =  stack.Peek() == '{' && par[i] == '}';

                        if (isRound || isCurly || isSquare)
                        {
                            stack.Pop();
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        stack.Push(par[i]);
                    }
                }
            }
            if (stack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
