using System;
using System.Collections.Generic;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine()); // 9
            int temp1 = greenLight;
            byte freeWindow = byte.Parse(Console.ReadLine()); // 3
            byte temp2 = freeWindow;
            string command;                                 // Mercedes
            Queue<string> line = new Queue<string>();
            
            byte carCounter = 0;
            while ((command = Console.ReadLine()) != "END")
            {
                if (command == "green")
                {
                    int n = line.Count;
                    for (int i = 0; i < n; i++)
                    {
                        if (greenLight == 0)
                        {
                            continue;
                        }

                        string peeked = line.Peek();
                        if (greenLight - peeked.Length > 0)
                        {
                            greenLight -= peeked.Length;
                            carCounter++;
                            line.Dequeue();
                        }
                        else
                        {
                            if (greenLight + freeWindow >= peeked.Length)
                            {
                                carCounter++;
                                line.Dequeue();
                                greenLight = 0;
                            }
                            else
                            {
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine("{0} was hit at {1}.", peeked, peeked[greenLight + freeWindow]);
                                return;
                            }
                        }
                        
                    }
                    greenLight = temp1;
                    freeWindow = temp2;                   
                }
                else
                {
                    line.Enqueue(command);
                }
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{carCounter} total cars passed the crossroads.");
        }
    }
}
