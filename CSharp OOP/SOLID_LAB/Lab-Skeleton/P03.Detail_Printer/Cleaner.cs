using System.Text;

namespace P03.Detail_Printer
{
    public class Cleaner : IEmployee
    {
        public Cleaner(string name, int roomsToClean)
        {
            Name = name;
            RoomsToClean = roomsToClean;
        }

        public string Name { get; set; }
        public int RoomsToClean { get; set; }

        public override string ToString()
        {
            
            return $"Name: {Name}, Rooms to clean: {RoomsToClean}";
        }
    }
}
