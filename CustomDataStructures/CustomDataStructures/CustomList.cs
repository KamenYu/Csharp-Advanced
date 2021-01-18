using System;
using System.Text;

namespace CustomDataStructures
{
    public class CustomList
    {
        private const int INITIAL_CAPACITY = 4;
        private int[] items;

        public CustomList()
        {
            items = new int[INITIAL_CAPACITY];
        }

        public int Count { get; private set; } // this will be used as an indexer && how many elements are in the array

        public int this[int index]
        {
            get
            {
                if (index >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return items[index];
            }
            set
            {
                if (index >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                items[index] = value;
            }
        }

        public void Add(int item)
        {
            if (Count == items.Length)
            {
                Resize();
            }

            items[Count] = item;
            Count++;
        }

        public bool Contains(int item)
        {
            foreach (var num in items)
            {
                if (num == item)
                {
                    return true;
                }
            }
            return false;
        }

        public int Find(Predicate<int> predicate)
        {
            int found = 0;

            for (int i = 0; i < Count; i++)
            {
                if (predicate(items[i]))
                {
                    found = items[i];
                    break;
                }
            }

            return found;
        }

        public int IndexOf(int item)
        {
            int indexOfValue = -1;
            for (int i = 0; i < Count; i++)
            {
                if (items[i] == item)
                {
                    indexOfValue = i;
                    break;
                }
            }
            return indexOfValue;
        }

        public int IndexOf(int item, int index)
        {
            int indexOfValue = -1;
            for (int i = index; i < Count; i++)
            {
                if (items[i] == item)
                {
                    indexOfValue = i;
                    break;
                }
            }
            return indexOfValue;
        }

        public void Insert(int index, int item)
        {
            if (!IsValidIndex(index)) // no = ??
            {
                throw new IndexOutOfRangeException();
            }

            if (Count >= items.Length)
            {
                Resize();
            }

            ShiftToRight(index);
            items[index] = item;
            Count++;
        }

        public int RemoveAt(int index)
        {
            if (!IsValidIndex(index))
            {
                throw new ArgumentOutOfRangeException();
            }

            int removed = items[index];
            ShiftToLeft(index);
            items[Count - 1] = default(int);
            Count--;

            if (Count <= items.Length / 4)
            {
                Shrink();
            }

            return removed;
        }

        public void Reverse()
        {
            int[] copy = new int[Count];
            int j = 0;
            for (int i = Count - 1; i >= 0; i--)
            {
                copy[j] = items[i];
                j++;
            }

            items = copy;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            if (!IsValidIndex(firstIndex) && !IsValidIndex(secondIndex))
            {
                throw new IndexOutOfRangeException();
            }

            items[firstIndex] = items[firstIndex] ^ items[secondIndex];
            items[secondIndex] = items[firstIndex] ^ items[secondIndex];
            items[firstIndex] = items[firstIndex] ^ items[secondIndex];
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < Count; i++)
            {
                sb = i != Count - 1 ? sb.Append($"{items[i]}, ") : sb.Append($"{items[i]}");
            }

            return sb.ToString().TrimEnd();
        }

        private bool IsValidIndex(int index)
            => index < Count || index < 0;

        private void Resize() // muliply items.Length * 2
        {
            int[] copy = new int[items.Length * 2];

            for (int i = 0; i < items.Length; i++)
            {
                copy[i] = items[i];
            }

            items = copy;
        }

        private void ShiftToLeft(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                items[i] = items[i + 1];
            }
        }

        private void ShiftToRight(int index)
        {
            for (int i = Count; i > index; i--)
            {
                items[i] = items[i - 1];
            }
        }

        private void Shrink()
        {
            int[] copy = new int[items.Length / 2];

            for (int i = 0; i < items.Length; i++)
            {
                copy[i] = items[i];
            }

            items = copy;
        }
    }
}
