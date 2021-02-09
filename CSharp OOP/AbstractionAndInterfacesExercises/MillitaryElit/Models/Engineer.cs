using System.Collections.Generic;
using System.Text;

using MillitaryElit.Contracts;
using MillitaryElit.Enumerators;

namespace MillitaryElit.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string id, string fName, string lName, decimal salary, SoldierCorpsEnum soldierCorpsEnum, ICollection<IRepair> repairs)
            : base(id, fName, lName, salary, soldierCorpsEnum)

        {
            Repairs = repairs;
        }

        public ICollection<IRepair> Repairs { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine("Repairs:");

            foreach (var rep in Repairs)
            {
                sb.AppendLine($"  {rep}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
