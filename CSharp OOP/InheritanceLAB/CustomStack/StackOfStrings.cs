using System.Collections.Generic;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            return Count == 0;
        }

        public void AddRange(Stack<string> stack)
        {
            while (stack.Count > 0)
            {
                this.Push(stack.Pop());
            }            
        }
    }
}
