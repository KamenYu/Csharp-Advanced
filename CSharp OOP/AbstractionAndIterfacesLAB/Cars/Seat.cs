namespace Cars
{
    public class Seat : ICar
    {
        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public string Model { get; set; }
        public string Color { get; set; }

        public void Start()
        {
        }

        public void Stop()
        {
        }

        public override string ToString()
        {
            return $"{Color} Seat {Model}\nEngine start\nBreaaak!";
        }
    }
}
