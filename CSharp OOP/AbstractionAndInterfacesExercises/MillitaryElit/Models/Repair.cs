using MillitaryElit.Contracts;

namespace MillitaryElit.Models
{
    public class Repair : IRepair
    {
        public Repair(string partName, int hWorked)
        {
            PartName = partName;
            HoursWorked = hWorked;
        }

        public string PartName { get; }

        public int HoursWorked { get; }

        public override string ToString()
        {
            return $"Part Name: {PartName} Hours Worked: {HoursWorked}";
        }
    }
}
