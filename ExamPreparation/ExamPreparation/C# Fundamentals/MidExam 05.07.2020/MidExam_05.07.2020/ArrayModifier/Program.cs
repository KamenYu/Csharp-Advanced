using System;
using System.Linq;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string[] commands = Console.ReadLine()
                .Split();

            while (commands[0] != "end")
            {
                switch (commands[0])
                {
                    case "swap":      // swap {index1} {index2}
                        int indexToSwap1 = int.Parse(commands[1]);
                        int indexToSwap2 = int.Parse(commands[2]);
                        int temp = array[indexToSwap1];
                        array[indexToSwap1] = array[indexToSwap2];
                        array[indexToSwap2] = temp;
                        break;

                    case "multiply":
                        int indexToMultiply1 = int.Parse(commands[1]);
                        int indexToMultiply2 = int.Parse(commands[2]);

                        array[indexToMultiply1] *= array[indexToMultiply2]; 
                        break;

                    case "decrease":
                        for (int i = 0; i < array.Length; i++)
                        {
                            array[i]--;
                        }
                        break;
                }
                commands = Console.ReadLine().Split();
            }
            Console.WriteLine(String.Join(", " , array));
        }
    }
}
