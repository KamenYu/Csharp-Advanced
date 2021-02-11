namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQ, double fuelC, double tankC) : base(fuelQ, fuelC, tankC)
        { }

        double ExtraConsumtionForSummer = 0.9;

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
    }
}
