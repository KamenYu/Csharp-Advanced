using System.Collections.Generic;

namespace P02._Identity_Before.Contracts
{
    public interface IOnlineUserGetter
    {
        IEnumerable<IUser> GetAllUsersOnline();
    }
}
