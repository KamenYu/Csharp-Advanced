using System.Collections.Generic;
using System.Text;

using MillitaryElit.Contracts;
namespace MillitaryElit.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(string id, string fName, string lName, decimal salary, ICollection<IPrivate> privates) :
            base(id, fName, lName, salary)
        {
            Privates = privates;
        }

        public ICollection<IPrivate> Privates { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine("Privates:");

            foreach (var item in Privates)
            {
                sb.AppendLine($"  {item}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
