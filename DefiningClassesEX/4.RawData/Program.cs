using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Tire tire1 = new Tire(double.Parse(carInfo[5]),  int.Parse(carInfo[6]));
                Tire tire2 = new Tire(double.Parse(carInfo[7]),  int.Parse(carInfo[8]));
                Tire tire3 = new Tire(double.Parse(carInfo[9]),  int.Parse(carInfo[10]));
                Tire tire4 = new Tire(double.Parse(carInfo[11]), int.Parse(carInfo[12]));

                List<Tire> tires = new List<Tire>()
                {
                    tire1, tire2, tire3, tire4
                };

                Car currentCar = new Car(model, engine, cargo, tires);
                cars.Add(currentCar);
            }

            // "fragile" - print all cars whose cargo is "fragile" with a tire, whose pressure is < 1
            // "flamable" - print all of the cars, whose cargo is "flamable" and have engine power > 250

            if (Console.ReadLine() == "fragile")
            {
                cars = cars
                    .Where(x => x.Cargo.CargoType == "fragile")
                    .ToList();
               // cars.Select(x => x.Tires.Where(y => y.TirePressure < 1));

                foreach (var car in cars)
                {
                    if (car.Tires.Any(x => x.TirePressure < 1))
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else
            {
                cars = cars.Where(x => x.Cargo.CargoType == "flamable").ToList();

                foreach (var car in cars)
                {
                    if (car.Engine.EnginePower > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}
