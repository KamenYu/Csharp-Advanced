using System;
using System.Collections.Generic;
using System.Linq;
namespace _3.SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            // "{model} {fuelAmount} {fuelConsumptionFor1km}"
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Car car = new Car(carInfo[0], double.Parse(carInfo[1]), double.Parse(carInfo[2]));
                cars.Add(car);
            }

            string command = Console.ReadLine();
            
            while (command != "End")
            {
                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries); // "Drive {carModel} {amountOfKm}"
                Car current = cars.First(x => x.Model == tokens[1]);
                current.Drive(double.Parse(tokens[2]));
                command = Console.ReadLine();
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
