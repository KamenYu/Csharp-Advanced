using System;
namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine(321, 7658);
            Tire[] tires = new Tire[4]
            {
                new Tire(1, 3.2),
                new Tire(1, 2.2),
                new Tire(2, 0.9),
                new Tire(1, 2.1),
            };

            var car = new Car("Lambo", "Urus", 2010, 3000, 21, engine, tires);           
        }
    }
}
