using System;
using PromoDemo;
using NUnit.Framework;

namespace PromotionTests
{
    public class Tests
    {
        static readonly DateTime monday = new DateTime(2021, 3, 22);
        static readonly DateTime tuesday = new DateTime(2021, 3, 23);
        static readonly DateTime wednesday = new DateTime(2021, 3, 24);

        [Test]
        public void Test1()
        {
            // without the dependency inversion the test is difficult to make
            Promotion promo = new Promotion(new DateTime());
            int discount = 0;
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                discount = promo.Get();
            }
            if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
            {
                discount = promo.Get();
            }//so on and so forth
        }

        [Test]
        public void PromotionReturns30PercentDiscountWhenDayIsMonday()
        {
            // with the dependency inversion the test is simple
            Promotion promo = new Promotion(monday);

            Assert.AreEqual(30, promo.Get());
        }

        [Test]
        public void PromotionReturns20PercentDiscountWhenDayIsTuesday()
        {
            Promotion promo = new Promotion(tuesday);

            Assert.AreEqual(20, promo.Get());
        }

        [Test]
        public void PromotionReturns10PercentDiscountWhenDayIsWednesday()
        {
            Promotion promo = new Promotion(wednesday);

            Assert.AreEqual(20, promo.Get());
        }
    }
}