using System.Text;

using MillitaryElit.Contracts;
using MillitaryElit.Enumerators;

namespace MillitaryElit.Models
{
    public class SpecialisedSoldier :Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(string id, string fName, string lName, decimal salary, SoldierCorpsEnum soldierCorpsEnum)
            : base(id, fName, lName, salary)
        {
            SoldierCorpsEnum = soldierCorpsEnum;
        }

        public SoldierCorpsEnum SoldierCorpsEnum { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine($"Corps: {SoldierCorpsEnum}");

            return sb.ToString().Trim();
        }
    }
}
