using System.Collections.Generic;

namespace P02._Identity_Before.Contracts
{
    public interface IAllUsersGetter
    {
        IEnumerable<IUser> GetAllUsers();
    }
}
