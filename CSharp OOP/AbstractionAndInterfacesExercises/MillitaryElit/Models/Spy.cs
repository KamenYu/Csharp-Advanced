using MillitaryElit.Contracts;

namespace MillitaryElit.Models
{
    public class Spy : Soldier, ISpy
    {
        public Spy(string id, string fName, string lName, int cNUm)
            : base(id, fName, lName)
        {
            CodeNumber = cNUm;
        }

        public int CodeNumber { get; }

        public override string ToString()
        {
            return $"{base.ToString()} Code Number: {CodeNumber}";
        }
    }
}
