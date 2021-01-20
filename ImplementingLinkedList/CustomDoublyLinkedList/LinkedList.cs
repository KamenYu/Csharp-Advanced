using System;
using System.Collections.Generic;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        public Node<T> Head { get; set; }

        public Node<T> Tail { get; set; }


        public void AddFirst(Node<T> newHead) // O(1)
        {
            if (Head == null)
            {
                Head = newHead;
                Tail = newHead;
            }
            else
            {
                newHead.Next = Head;
                Head.Previous = newHead;
                Head = newHead;
            }
        }
        
        public void AddLast(Node<T> newTail) // O(1)
        {
            if (Tail == null)
            {
                Head = newTail;
                Tail = newTail;
            }
            else
            {
                newTail.Previous = Tail;
                Tail.Next = newTail;
                Tail = newTail;
            }
        }

        public bool Contains(T value) // O(n)
        {
            bool isThere = false;

            ForEach(node =>
            {
                if (node.Value.Equals(value)) isThere = true;
                
            });

            return isThere;
        }

        public bool Remove(T value) // O(n)
        {
            Node<T> current = Head;

            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                    return true;
                }

                current = current.Next;
            }
            return false;
        }

        public Node<T> RemoveFirst() // O(1)
        {
            var oldHead = Head;
            Head = Head.Next;
            Head.Previous = null;
            return oldHead;
        }

        public Node<T> RemoveLast() // O(1)
        {
            var oldTail = Tail;
            Tail = Tail.Previous;
            Tail.Next = null;
            return oldTail;
        }

        public T Peek()
        {
            return Head.Value;
        }

        public void ForEach(Action<Node<T>> action)
        {
            Node<T> currentNode = Head;

            while (currentNode != null)
            {
                action(currentNode);
                currentNode = currentNode.Next;
            }
        }

        public void PrintList()
        {
            ForEach(node =>
            {
                Console.WriteLine(node.Value);
            });
        }

        public void PrintReversedList()
        {
            Node<T> current = Tail;

            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = Tail.Previous;
            }
        }

        public Node<T>[] ToArray()
        {
            List<Node<T>> list = new List<Node<T>>();
            ForEach(node => list.Add(node));
            return list.ToArray();
        }
    }
}
