using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {            Stack<int> lilies = new Stack<int>
                (Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Queue<int> roses = new Queue<int>
                (Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            int sum = 0;
            int wreaths = 0;
            int scraps = 0;

            while (lilies.Count > 0 && roses.Count > 0)
            {
                sum = lilies.Pop() + roses.Dequeue();

                while (true)
                {
                    if (sum == 15)
                    {
                        wreaths++;
                        break;
                    }
                    else if (sum < 15)
                    {
                        scraps += sum;
                        break;
                    }
                    else
                    {
                        sum -= 2;
                    }
                }
            }

            wreaths += scraps / 15;

            if (wreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreaths} wreaths more!");
            }
        }
    }
}
