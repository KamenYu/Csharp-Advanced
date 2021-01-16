using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();
            // "{model} {power} {displacement} {efficiency}"
            //  stirng    int     int             string
           
            for (int i = 0; i < n; i++)
            {
                Engine currEngine = new Engine();
                string[] engineInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                currEngine.Model = engineInfo[0];
                currEngine.Power = int.Parse(engineInfo[1]);

                
                if (engineInfo.Length == 2)
                {
                    engines.Add(currEngine);
                }
                else if (engineInfo.Length == 3)
                {
                    int displacement = 0;
                    if (int.TryParse(engineInfo[2], out displacement))
                    {
                        currEngine.Displacement = engineInfo[2];
                        engines.Add(currEngine);
                    }
                    else
                    {
                        currEngine.Efficiency = engineInfo[2];
                        engines.Add(currEngine);
                    }
                }
                else if (engineInfo.Length == 4)
                {
                    currEngine.Displacement = engineInfo[2];
                    currEngine.Efficiency = engineInfo[3];
                    engines.Add(currEngine);
                }               
            }

            int m = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            // "{model} {engine} {weight} {colour}"
            // string    string   int       string

            for (int i = 0; i < m; i++)
            {
                Car currentCar = new Car();
                string[] carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                currentCar.Model = carInfo[0];
                currentCar.Engine = engines.Where(x => x.Model == carInfo[1]).FirstOrDefault();

                if (carInfo.Length == 2)
                {
                    cars.Add(currentCar);
                }
                else if (carInfo.Length == 3)
                {
                    int weight = 0;
                    if (int.TryParse(carInfo[2], out weight))
                    {
                        currentCar.Weight = carInfo[2];
                        cars.Add(currentCar);
                       
                    }
                    else
                    {
                        currentCar.Colour = carInfo[2];
                        cars.Add(currentCar);
                    }
                }
                else if (carInfo.Length == 4)
                {
                    currentCar.Weight = carInfo[2];
                    currentCar.Colour = carInfo[3];
                    cars.Add(currentCar);
                }
            }

            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Model}:");
                Console.WriteLine($"  {item.Engine.Model}:");
                Console.WriteLine($"    Power: {item.Engine.Power}");
                Console.WriteLine($"    Displacement: {item.Engine.Displacement}");
                Console.WriteLine($"    Efficiency: {item.Engine.Efficiency}");                                                       
                Console.WriteLine($"  Weight: {item.Weight}");
                Console.WriteLine($"  Color: {item.Colour}");
            }
        }
    }
}
