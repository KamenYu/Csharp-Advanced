using System;
using Moq;

namespace PromoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Mock<Promotion> mockPromotion = new Mock<Promotion>();

            Console.WriteLine($"Today's promotion is : {mockPromotion.Object.Get()}");
            mockPromotion.Setup(m => m.Get()).Returns(20);
            Console.WriteLine($"Today's promotion is : {mockPromotion.Object.Get()}");
            mockPromotion.Setup(m => m.CalculateDiscount(100)) // here 100 is concrete example
                .Returns(80);
            mockPromotion.Setup(m => m.CalculateDiscount(It.IsAny<int>()));

            Promotion promo = new Promotion(today);
            Console.WriteLine(promo.CalculateDiscount(100));
            Console.WriteLine(promo.CalculateDiscount(101));
        }
    }
}
