namespace P02._Identity_Before.Contracts
{
    public interface IPassChanger
    {
        void ChangePassword(string oldPass, string newPass);
    }
}
