namespace MillitaryElit.Models
{
    public class Soldier : ISoldier
    {
        public Soldier(string id, string fName, string lName)
        {
            ID = id;
            FirstName = fName;
            LastName = lName;
        }

        public string ID { get; }
        public string FirstName { get; }
        public string LastName { get; }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Id: {ID}";
        }
    }
}
