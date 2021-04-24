using System;
namespace DecoratorPattern
{
    public class PaymentSystemDecorator : IPaymentSystem
    {
        private IPaymentSystem paymentSystem;

        public PaymentSystemDecorator(IPaymentSystem paymentSystem)
        {
            this.paymentSystem = paymentSystem;
        }
        public void Loan(string from, string to, int amount)
        {
            Console.WriteLine("Decorated payment system and logging in");
            paymentSystem.Loan(from, to, amount);
        }

        public void Pay(string from, string to, int amount)
        {
            Console.WriteLine("Decorated payment system and logging in");
            paymentSystem.Pay(from, to, amount);
                
        }
    }
}
