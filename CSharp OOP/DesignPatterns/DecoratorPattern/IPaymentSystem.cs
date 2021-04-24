using System;
namespace DecoratorPattern
{
    public interface IPaymentSystem
    {
        void Pay(string from, string to, int amount);

        void Loan(string from, string to, int amount);
    }
}
