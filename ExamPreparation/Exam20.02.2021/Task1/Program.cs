using System;
using System.Linq;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 90/ 100
            int n = int.Parse(Console.ReadLine());

            List<int> plates = new List<int>
                (Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            Stack<int> orcs = new Stack<int>
               (Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            n--;
            int counter = 1;

            while (true) // plates.Count > 0 || n > 0
            {
                if (orcs.Count == 0 && n == 0)
                {
                    break;
                }
                else if (plates.Count == 0)
                {
                    break;
                }

                if (orcs.Count == 0)
                {
                    orcs = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
                    n--;
                    counter++;
                }

                if (counter % 3 == 0)
                {
                    int additionalPlate = int.Parse(Console.ReadLine());
                    plates.Add(additionalPlate);
                    counter = 1;
                }

                if (plates[0] == orcs.Peek())
                {
                    plates.Remove(plates[0]);
                    orcs.Pop();
                }
                else if (plates[0] > orcs.Peek())
                {
                    int start = plates[0] - orcs.Pop();
                    plates.Remove(plates[0]);
                    plates.Insert(0, start);
                }
                else if (orcs.Peek() > plates[0])
                {
                    orcs.Push(orcs.Pop() - plates[0]);
                    plates.Remove(plates[0]);
                }
            }

            if (plates.Count == 0)
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");                
            }
            else if (orcs.Count == 0)
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");                
            }

            if (orcs.Count > 0)
            {
                Console.WriteLine($"Orcs left: {string.Join(", ", orcs)}");
            }
            if (plates.Count > 0)
            {
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }                       
        }
    }
}
