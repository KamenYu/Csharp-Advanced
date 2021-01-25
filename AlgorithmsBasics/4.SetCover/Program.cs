using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.SetCover
{
    class Program
    {
        public static void Main(string[] args)
        {
            // greedy algorithm

            var universe = new int[] { 1, 3, 5, 7, 9, 11, 20, 30, 40 };
            var sets = new[]
            {
                new[]{ 20},
                new[] {1,5,20,30},
                new[] {3,7,20,30,40},
                new[] {9,30},
                new[] {11,20,30,40},
                new[] {3,7,40 }
            };

            var selected = ChooseSets(sets.ToList(), universe.ToList());

            Console.WriteLine($"Sets to take({selected.Count}):");

            foreach (var item in selected)
            {
                Console.WriteLine($"{{ {string.Join(", ", item)} }}");
            }
        }

        private static List<int[]> ChooseSets(List<int[]> sets, List<int> universe)
        {
            var res = new List<int[]>();

            while (universe.Any())
            {
                var maxSet = sets.First();
                int maxCount = 0;

                foreach (var item in sets)
                {
                    int count = item.Count(universe.Contains);

                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxSet = item;
                    }
                }

                res.Add(maxSet);
                sets.Remove(maxSet);

                foreach (var item in maxSet)
                {
                    universe.Remove(item);
                }

            }

            return res;
        }
        
    }
}
