using System.Collections.Generic;
using System.Text;

using MillitaryElit.Contracts;
using MillitaryElit.Enumerators;
namespace MillitaryElit.Models
{
    public class Comando : SpecialisedSoldier, IComando
    {
        public Comando(string id, string fName, string lName, decimal salary, SoldierCorpsEnum soldierCorpsEnum, ICollection<IMission> missions)
            : base(id, fName, lName, salary, soldierCorpsEnum)
        {
            Missions = missions;
        }

        public ICollection<IMission> Missions { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine("Missions:");
            foreach (var mis in Missions)
            {
                sb.AppendLine($"  {mis}");
            }

            return sb.ToString().Trim();
        }
    }
}
