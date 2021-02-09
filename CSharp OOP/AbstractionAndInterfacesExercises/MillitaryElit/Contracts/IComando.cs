using System.Collections.Generic;

using MillitaryElit.Models;

namespace MillitaryElit.Contracts
{
    public interface IComando
    {
        ICollection<IMission> Missions { get; }
    }
}
