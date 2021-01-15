using System;
namespace CarManufacturer
{
    public class Car
    {
        public Car(string make, string model, int year, int horsePower, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)         
        {
            Make = make;
            Model = model;
            Year = year;
            Engine.HorsePower = horsePower;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            Engine = engine;
            Tires = tires;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }

        public void Drive(double distance)
        {
            double res = FuelQuantity - distance * FuelConsumption / 100;

            if (res > 0)
            {
                FuelQuantity = res;
            }
            else
            {
                Console.WriteLine($"Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return $"Make: {Make}\nModel: {Model}\nYear: {Year}\nHorsePowers: {Engine.HorsePower}\nFuel: {FuelQuantity}";
        }
    }
}
