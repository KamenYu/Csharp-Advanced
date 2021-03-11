using System;
namespace P02._Identity_Before.Contracts
{
    public interface IRequirements
    {
        bool RequireUniqueEmail { get; }

        int MinRequiredPasswordLength { get; }

        int MaxRequiredPasswordLength { get; }
    }
}
