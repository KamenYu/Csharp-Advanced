using System.Collections.Generic;
using System.Text;

using P03.Detail_Printer;

namespace P03.DetailPrinter
{
    public class Manager : IEmployee
    {
        public Manager(string name, ICollection<string> documents)
        {
            Name = name;
            Documents = new List<string>(documents);
        }

        public string Name { get; set; }
        public IReadOnlyCollection<string> Documents { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Name: {Name}");
            result.AppendLine("Documents:");
            foreach (var item in Documents)
            {
                
                result.AppendLine($"  {item}");
            }

            return result.ToString().Trim();
        }
    }
}
