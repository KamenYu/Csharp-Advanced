namespace _4.RawData
{
    public class Cargo
    {
        public Cargo(int weight, string type)
        {
            CargoWeight = weight;
            CargoType = type;
        }

        public int CargoWeight { get; set; }

        public string CargoType { get; set; }
    }
}
