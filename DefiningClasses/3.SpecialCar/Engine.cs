using System;
namespace _3.SpecialCar
{
    public class Engine
    {
        public Engine(int horsePower, double cubicCapacity)
        {
            HorsePower = horsePower;
            CubicCapacity = cubicCapacity;
        }

        public int HorsePower { get; set; }
        public double CubicCapacity { get; set; }
    }
}
