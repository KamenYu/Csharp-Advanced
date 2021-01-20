using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.GenericSwapMethodStringAndInt
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> values = new List<int>();
            for (int i = 0; i < n; i++)
            {
                values.Add(int.Parse(Console.ReadLine()));
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int f = indexes[0];
            int s = indexes[1];

            //Box<string> box = new Box<string>(values);
            //box.Swap(f, s);
            //Console.WriteLine(box);

            Swap(values, f, s);

            foreach (var item in values)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }

        public static void Swap<T>(List<T> list, int first, int second)
        {
            if (IndexChecker(first, list.Count) && IndexChecker(second, list.Count))
            {
                T temp = list[first];
                list[first] = list[second];
                list[second] = temp;
            }
        }

        public static bool IndexChecker(int index, int count)
        {
            return index >= 0 && index < count;
        }
    }
}
