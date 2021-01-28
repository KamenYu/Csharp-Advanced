namespace NeedForSpeed
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SportCar sCar = new SportCar(80, 3000);
            sCar.Drive(30);

            RaceMotorcycle rM = new RaceMotorcycle(120, 460.987);
            rM.Drive(78.01);
        }
    }
}
