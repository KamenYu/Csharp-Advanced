using System;
namespace DecoratorPattern
{
    public class PaymentSystem : IPaymentSystem
    {
        public void Loan(string from, string to, int amount)
        {
            Console.WriteLine($"Loaned {amount} from {from}, to {to}");
        }

        public void Pay(string from, string to, int amount)
        {
            Console.WriteLine($"Paid {amount} from {from}, to {to}");
        }
    }
}
