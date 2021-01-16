using System;
namespace _3.SpeedRacing
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPer1KM)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPer1KM;
        }

        public Car(string model)
        {
            Model = model;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; } = 0;

        public void Drive(double distance)
        {
            double fuelToDrive = distance * FuelConsumptionPerKilometer;

            if (FuelAmount >= fuelToDrive)
            {
                FuelAmount -= fuelToDrive;
                TravelledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
