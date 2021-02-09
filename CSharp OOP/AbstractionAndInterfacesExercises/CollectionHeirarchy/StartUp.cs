using System;
using System.Text;

using CollectionHeirarchy.Interfaces;
using CollectionHeirarchy.Models;

namespace CollectionHeirarchy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] items = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int amountOfRemoveOperations = int.Parse(Console.ReadLine());

            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();

            Console.WriteLine(PrintFirstLine(addCollection, items));
            Console.WriteLine(PrintSecondLine(addRemoveCollection, items));
            Console.WriteLine(PrintSecondLine(myList, items));
            Console.WriteLine(RemoveAmountOfStringsML(myList, amountOfRemoveOperations)); // it should be ARC first then ML
            Console.WriteLine(RemoveAmountOfStringsIARC(addRemoveCollection, amountOfRemoveOperations));
        }

        public static string RemoveAmountOfStringsIARC(IAddRemoveCollection addRemoveCollection, int amountOfRemoveOperations)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < amountOfRemoveOperations; i++)
            {
                sb.Append(addRemoveCollection.Remove() + " ");
            }

            return sb.ToString().Trim();
        }

        public static string RemoveAmountOfStringsML(IMyList myList, int amountOfRemoveOperations)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < amountOfRemoveOperations; i++)
            {
                sb.Append(myList.Remove() + " ");
            }

            return sb.ToString().Trim();
        }

        public static string PrintFirstLine(IAddCollection collection, string[] items)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in items)
            {
                sb.Append(collection.Add(item) + " ");
            }

            return sb.ToString().Trim();
        }

        public static string PrintSecondLine(IAddRemoveCollection collection, string[] items)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in items)
            {
                sb.Append(collection.Add(item) + " ");
            }

            return sb.ToString().Trim();
        }
    }
}
