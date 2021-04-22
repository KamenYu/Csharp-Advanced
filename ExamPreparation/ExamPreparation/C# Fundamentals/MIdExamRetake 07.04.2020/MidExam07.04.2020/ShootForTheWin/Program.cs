using System;
using System.Linq;

namespace ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            // 24 50 36 70
            // 0  1  2  3

            string input;
            int shotTargets = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                int index = int.Parse(input);

                if (index > targets.Length - 1)
                {
                    continue;
                }
                else
                {
                    int temp = targets[index];
                    if (targets[index] == -1)
                    {
                        continue;
                    }
                    
                    for (int i = 0; i < targets.Length; i++)
                    {
                        if (targets[i] < 0)
                        {
                            targets[i] = -1;
                        }
                        else if (targets[i] <= temp)
                        {
                            targets[i] += temp;
                        }
                        else if (targets[i] > temp)
                        {
                            targets[i] -= temp;
                        }
                    }
                    targets[index] = -1;
                    shotTargets++;
                }               
            }
            Console.WriteLine($"Shot targets: {shotTargets} -> {String.Join(" ", targets)}");
        }
    }
}
