using System.Collections.Generic;

namespace MillitaryElit.Contracts
{
    public interface ILieutenantGeneral
    {
        public ICollection<IPrivate> Privates { get; }
    }
}
