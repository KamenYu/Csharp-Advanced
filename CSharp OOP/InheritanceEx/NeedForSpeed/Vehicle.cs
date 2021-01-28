namespace NeedForSpeed
{
    public class Vehicle
    {
        private double DefaultFuelConsumption = 1.25; // const

        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }

        public virtual double FuelConsumption
        {
            get
            {
                return DefaultFuelConsumption;
            }
        } 

        public double Fuel { get; set; }

        public int HorsePower { get; set; }

        public void Drive(double kilometers) // virtual
        {
            Fuel -= FuelConsumption * kilometers;
        }
    }
}
