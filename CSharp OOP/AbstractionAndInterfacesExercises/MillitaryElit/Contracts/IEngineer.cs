using System.Collections.Generic;

namespace MillitaryElit.Contracts
{
    public interface IEngineer
    {
        ICollection<IRepair> Repairs { get; }
    }
}
