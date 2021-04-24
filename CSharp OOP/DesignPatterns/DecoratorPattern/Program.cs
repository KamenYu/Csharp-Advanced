using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // to add dynamically extra functionality to an object
            IPaymentSystem payment = new PaymentSystem();

            payment.Loan("Pesho", "Baj Pesho", 10);
            payment.Pay("Lelja", "Baba", 100);
            payment.Loan("Lila", "Mila", 100);
            payment.Pay("Niko", "Nimiety", 1099000);
            Console.WriteLine(new string('-', 40));
            IPaymentSystem system = new PaymentSystemDecorator(new PaymentSystem());

            system.Loan("Pesho", "Baj Pesho", 10);
            system.Pay("Lelja", "Baba", 100);
            system.Loan("Lila", "Mila", 100);
            system.Pay("Niko", "Nimiety", 1099000);
        }
    }
}
