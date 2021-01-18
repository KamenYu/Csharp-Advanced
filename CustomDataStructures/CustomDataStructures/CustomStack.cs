using System;
namespace CustomDataStructures
{
    public class CustomStack
    {
        private const int INITIAL_CAPACITY = 2;
        private const string ERROR_MESSAGE = "Stack is empty";
        private int[] items;

        public CustomStack()
        {
            items = new int[INITIAL_CAPACITY];
        }

        public int Count { get; private set; }

        public void Push(int item)
        {
            if (Count == items.Length)
            {
                Resize();
            }

            items[Count] = item;
            Count++;
        }

        public int Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException(ERROR_MESSAGE);
            }
            int popped = items[Count - 1];
            Count--;
            return popped;
        }

        public int Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException(ERROR_MESSAGE);
            }
            int peeked = items[Count - 1]; 

            return peeked;
        }

        public void ForEach(Action<int> action)
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                action(items[i]);
            }
        }

        private void Resize()
        {
            int[] copy = new int[items.Length * 2];

            for (int i = 0; i < items.Length; i++)
            {
                copy[i] = items[i];
            }

            items = copy;
        }
    }
}
