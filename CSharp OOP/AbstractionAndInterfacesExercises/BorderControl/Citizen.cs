namespace BorderControl
{
    public class Citizen : Entity, IBirthed, IBuyer
    {
        public Citizen(string name, int age, string id, string bDate)
        {
            Name = name;
            Age = age;
            ID = id;
            Birthdate = bDate;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string ID { get; set; }

        public string Birthdate { get; set; }

        public int Food { get; set; } = 0;

        public void BuyFood()
        {
            Food = 10;
        }
    }
}
