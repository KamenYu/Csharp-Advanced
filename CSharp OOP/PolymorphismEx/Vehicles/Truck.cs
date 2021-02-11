using System;
namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQ, double fuelC, double tankC) : base(fuelQ, fuelC, tankC)
        { }

        double ExtraConsumtionForSummer = 1.6;

        public override void Drive(double distance, string type)
        {
            double temp = FuelQuantity;
            FuelQuantity -= distance * FuelConsumption + distance * ExtraConsumtionForSummer;

            base.Drive(distance, type);
            
            if (FuelQuantity <= 0)
            {
                FuelQuantity = temp;
            }
        }

        public override void Refuel(double fuel)
        {            
            if (fuel <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                double temp = FuelQuantity;
                FuelQuantity += fuel * 0.95;

                if (FuelQuantity >= TankCapacity)
                {
                    FuelQuantity = temp;
                    Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
                }
            }
        }
    }
}
