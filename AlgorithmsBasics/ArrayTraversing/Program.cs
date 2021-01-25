using System;

namespace ArrayTraversing
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4 };
            Traverse(array, 1);
        }

        static void Traverse<T>(T[] collection, int index)
        {
            if (index == collection.Length)
            {
                return;
            }

            Console.WriteLine(collection[index]);
            Traverse(collection, index + 1);
            Console.WriteLine(collection[index]);
           // Console.WriteLine("After Recursion");
        }
    }
}
