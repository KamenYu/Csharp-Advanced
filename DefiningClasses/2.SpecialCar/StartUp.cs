using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var tires = new List<Tire[]>();                      

            while (input != "No more tires")
            {
                string [] tireInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var currTires = new Tire[4]
                {
                    new Tire(int.Parse(tireInfo[0]), double.Parse(tireInfo[1])),
                    new Tire(int.Parse(tireInfo[2]), double.Parse(tireInfo[3])),
                    new Tire(int.Parse(tireInfo[4]), double.Parse(tireInfo[5])),
                    new Tire(int.Parse(tireInfo[6]), double.Parse(tireInfo[7]))
                };

                tires.Add(currTires);
                input = Console.ReadLine();
            }

            var engines = new List<Engine>();
            input = Console.ReadLine();
            while (input != "Engines done")
            {
                string[] engineInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Engine currEngine = new Engine(int.Parse(engineInfo[0]), double.Parse(engineInfo[1]));
                engines.Add(currEngine);

                input = Console.ReadLine();
            }

            var cars = new List<Car>();
            input = Console.ReadLine();
            while (input != "Show special")
            {
                string[] carInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                // {make} {model} {year} {fuelQuantity} {fuelConsumption} {engineIndex} {tiresIndex}

                string make = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                double fuelQuantity = double.Parse(carInfo[3]);
                double fuelConsumtion = double.Parse(carInfo[4]);
                int engineIndex = int.Parse(carInfo[5]);
                int tiresIndex = int.Parse(carInfo[6]);

                if (engineIndex >= 0 && engineIndex < engines.Count && tiresIndex >= 0 && tiresIndex < tires.Count)
                {
                    Car car = new Car(make, model, year, engines[engineIndex].HorsePower, fuelQuantity, fuelConsumtion, engines[engineIndex], tires[tiresIndex]);
                    cars.Add(car);
                }
                
                input = Console.ReadLine();
            }

            cars = cars.Where(y => y.Year >= 2017 && y.Engine.HorsePower > 330
                    && y.Tires.Sum(p => p.Pressure) > 9
                    && y.Tires.Sum(p => p.Pressure) < 10).ToList();

            foreach (var car in cars)
            {
                car.Drive(20);
                Console.WriteLine(car.WhoAmI());
            }
        }
    }
}
