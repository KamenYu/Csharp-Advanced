using System.Collections.Generic;

namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> stack;

        public int Count
        {
            get
            {
                return stack.Count;
            }
        }

        public Box()
        {
            stack = new Stack<T>(8);
        }

        public void Add(T element)
        {
            stack.Push(element);
        }

        public T Remove()
        {
            return stack.Pop();
        }
    }
}
