namespace BorderControl
{
    public class Pet : IBirthed
    {
        public Pet(string name, string bDate)
        {
            Name = name;
            Birthdate = bDate;
        }

        public string Name { get; set; }

        public string Birthdate { get; set; }
    }
}
