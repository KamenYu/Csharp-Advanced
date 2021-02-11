using System;
using System.Linq;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Skip(1).ToArray();
            Vehicle car = new Car(double.Parse(carInfo[0]), double.Parse(carInfo[1]), double.Parse(carInfo[2]));

            string[] truckInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Skip(1).ToArray();
            Vehicle truck = new Truck(double.Parse(truckInfo[0]), double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

            string[] busInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Skip(1).ToArray();
            Vehicle bus = new Bus(double.Parse(busInfo[0]), double.Parse(busInfo[1]), double.Parse(busInfo[2]));

            int amountOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < amountOfCommands; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (command[1] == "Car")
                {
                    if (command[0] == "Drive")
                    {                        
                        car.Drive(double.Parse(command[2]), command[1]);
                    }
                    else if (command[0] == "Refuel")
                    {
                        car.Refuel(double.Parse(command[2]));
                    }
                }
                else if (command[1] == "Truck")
                {
                    if (command[0] == "Drive")
                    {
                        truck.Drive(double.Parse(command[2]), command[1]);
                    }
                    else if (command[0] == "Refuel")
                    {
                        truck.Refuel(double.Parse(command[2]));
                    }
                }
                else if (command[1] == "Bus")
                {
                    if (command[0] == "Drive" || command[0] == "DriveEmpty")
                    {
                        bus.Drive(double.Parse(command[2]), command[0]);
                    }
                    else if (command[0] == "Refuel")
                    {
                        bus.Refuel(double.Parse(command[2]));
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }
    }
}
