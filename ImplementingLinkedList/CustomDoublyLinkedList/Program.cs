namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            for (int i = 0; i < 5; i++)
            {
                list.AddFirst(new Node(i));
            }
            list.PrintList();
        }
    }
}
