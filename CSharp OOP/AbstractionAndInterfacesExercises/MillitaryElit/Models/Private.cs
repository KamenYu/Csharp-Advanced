using System;

namespace MillitaryElit.Models
{
    public class Private : Soldier, IPrivate
    {
        public Private(string id, string fName, string lName, decimal salary)
            :base( id, fName, lName)
        {
            Salary = salary;
        }

        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} Salary: {Math.Round(Salary,2):f2}";
        }
    }
}
