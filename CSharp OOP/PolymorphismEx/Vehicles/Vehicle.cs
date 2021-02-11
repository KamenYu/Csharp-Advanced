using System;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public Vehicle(double fuelQ, double fuelC, double tankCapacity)
        {
            FuelQuantity = fuelQ > tankCapacity ? 0 : fuelQ; // here
            FuelConsumption = fuelC;
            TankCapacity = tankCapacity;
        }

        public double TankCapacity { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public virtual void Drive(double distance, string type)
        {
            double temp = FuelQuantity;

            if (FuelQuantity < 0)
            {
                FuelQuantity = temp;
                Console.WriteLine($"{IfBus(type)} needs refueling");
            }
            else
            {
                Console.WriteLine($"{IfBus(type)} travelled {distance} km");
            }
        }

        public virtual void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                double temp = FuelQuantity;
                FuelQuantity += fuel;

                if (FuelQuantity >= TankCapacity)
                {
                    FuelQuantity = temp;
                    Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
                }
            }            
        }

        private string IfBus(string type)
        {
            if (type == "Drive" || type == "DriveEmpty")
            {
                return "Bus";
            }
            else
            {
                return type;
            }
        }
    }
}
