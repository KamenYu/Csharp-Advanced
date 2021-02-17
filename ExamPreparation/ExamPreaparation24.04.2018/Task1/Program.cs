using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine()); // 1-100
            int greenLightTemp = greenLightDuration;
            int windowDuration = int.Parse(Console.ReadLine()); // 0-100
            int windowTemp = windowDuration;

            Queue<string> cars = new Queue<string>();

            string command;
            int passedCars = 0;
            while ((command = Console.ReadLine()) != "END")
            {
                if (command == "green")
                {
                    if (cars.Count == 0)
                    {
                        break;
                    }

                    string currentCar = cars.Peek();
                    while (true)
                    {
                        if (greenLightDuration == 0 && currentCar.Length > windowDuration)
                        {
                            break;
                        }

                        if (currentCar.Length <= greenLightDuration)
                        {                           
                            greenLightDuration -= currentCar.Length;
                            cars.Dequeue();
                            passedCars++;
                        }
                        else // car = 8, grL = 6, wind = 4
                        {
                            if (currentCar.Length <= greenLightDuration + windowDuration)
                            {
                                windowDuration = greenLightDuration + windowDuration - currentCar.Length;
                                greenLightDuration = 0;
                                cars.Dequeue();
                                passedCars++;
                            }
                            else
                            {
                                char[] crashedCar = currentCar.ToCharArray();
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{currentCar} was hit at {crashedCar[greenLightDuration +windowDuration]}.");
                                return;
                            }
                        }

                        if (cars.Count == 0)
                        {
                            break;
                        }

                        currentCar = cars.Peek();
                    }

                    greenLightDuration = greenLightTemp;
                    windowDuration = windowTemp;
                }
                else
                {
                    cars.Enqueue(command);
                }
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{passedCars} total cars passed the crossroads.");
        }
    }
}
