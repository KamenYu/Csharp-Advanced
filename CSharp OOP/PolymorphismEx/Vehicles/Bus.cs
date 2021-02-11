namespace Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQ, double fuelC, double tankC) : base(fuelQ, fuelC, tankC)
        { }

        double ExtraConsumtionForSummer = 1.4;

        public override void Drive(double distance, string type)
        {
            double temp = FuelQuantity;

            if (type == "DriveEmpty")
            {
                FuelQuantity -= distance * FuelConsumption;
            }
            else if (type == "Drive") // with people
            {
                FuelQuantity -= distance * FuelConsumption + distance * ExtraConsumtionForSummer;
            }          

            base.Drive(distance, type);

            if (FuelQuantity <= 0)
            {
                FuelQuantity = temp;
            }
        }
    }
}
