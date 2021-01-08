using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> nSet = new HashSet<int>();
            HashSet<int> mSet = new HashSet<int>();
            int[] nAndm = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < nAndm[0]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                nSet.Add(num);              
            }

            for (int i = 0; i < nAndm[1]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                mSet.Add(num);
            }

            nSet.IntersectWith(mSet);
            Console.WriteLine(string.Join(' ', nSet));
        }
    }
}
