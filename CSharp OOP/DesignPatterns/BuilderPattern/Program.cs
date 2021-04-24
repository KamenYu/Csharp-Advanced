using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // for complex objects where we need only parts of the object, not the whole
            Car car = new Car();
            CarBuilder builder = new CarBuilder();

            //builder.BuildEngine(car);
            //builder.BuildTyres(car);
            //builder.BuildDoors(car); -> BuilderPattern

            builder
                .BuildDoors(car)
                .BuildEngine(car)
                .BuildEngine(car)
                .BuildTyres(car)
                .BuildDoors(car); // Fluent API || method chainnig 

            Console.WriteLine($"Engine is - {car.Engine}, " +
                $"Tyres are - {car.Tyres}, " +
                $"Doors can - {car.Doors}");

        }
    }
}
