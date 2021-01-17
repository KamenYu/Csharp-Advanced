using System;
using System.Collections.Generic;

namespace CustomDoublyLinkedList
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public Node Tail { get; set; }


        public void AddFirst(Node newHead) // O(1)
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
        
        public void AddLast(Node newTail) // O(1)
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

        public bool Contains(int value) // O(n)
        {
            bool isThere = false;

            ForEach(node =>
            {
                if (node.Value == value) isThere = true;
                
            });

            return isThere;
        }

        public bool Remove(int value) // O(n)
        {
            Node current = Head;

            while (current != null)
            {
                if (current.Value == value)
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                    return true;
                }

                current = current.Next;
            }
            return false;
        }

        public Node RemoveFirst() // O(1)
        {
            var oldHead = Head;
            Head = Head.Next;
            Head.Previous = null;
            return oldHead;
        }

        public Node RemoveLast() // O(1)
        {
            var oldTail = Tail;
            Tail = Tail.Previous;
            Tail.Next = null;
            return oldTail;
        }

        public int Peek()
        {
            return Head.Value;
        }

        public void ForEach(Action<Node> action)
        {
            Node currentNode = Head;

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
            Node current = Tail;

            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = Tail.Previous;
            }
        }

        public Node[] ToArray()
        {
            List<Node> list = new List<Node>();
            ForEach(node => list.Add(node));
            return list.ToArray();
        }
    }
}
