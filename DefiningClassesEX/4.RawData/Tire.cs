namespace _4.RawData
{
    public class Tire
    {
        public Tire(double pressure, int age)
        {
            TirePressure = pressure;
            TireAge = age;
        }

        public double TirePressure { get; set; }

        public int TireAge { get; set; }
    }
}
