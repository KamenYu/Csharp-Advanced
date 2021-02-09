namespace BorderControl
{
    public class Robot : Entity
    {
        public Robot(string model, string id)
        {
            Model = model;
            ID = id;
        }

        public string Model { get; set; }

        public string ID { get; set; }
    }
}