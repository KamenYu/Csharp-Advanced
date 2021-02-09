namespace PersonInfo
{
    public class Citizen : IPerson, IBirthable, IIdentifiable
    {
        private string name;
        private int age;
        private string id;
        private string birthDate;

        public Citizen(string name, int age, string id, string birthDate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthDate;
        }

        public string Name { get { return name; } set { name = value; } }

        public int Age { get { return age; } set { age = value; } }

        public string Id { get { return id; } set { id = value; } }

        public string Birthdate { get { return birthDate; } set { birthDate = value; } }
    }
}