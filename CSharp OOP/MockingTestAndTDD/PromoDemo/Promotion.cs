using System;
namespace PromoDemo
{
    public class Promotion
    {
        private DateTime dateToday;// dependency

        public Promotion(DateTime today)
        {
            //dateToday = DateTime.Now; // this is similar to "new" DateTime, this makes is hard to test
            dateToday = today;
        }

        public Promotion() : this(DateTime.Now)
        {
            //in order to mock classes I need parameterless ctor
        }

        public virtual int CalculateDiscount(int price)
        {
            return price - price * Get() / 100;
        }

        public virtual int Get()
        {
            if (dateToday.DayOfWeek == DayOfWeek.Monday)
            {
                return 30;
            }
            if (dateToday.DayOfWeek == DayOfWeek.Tuesday)
            {
                return 20;
            }
            if (dateToday.DayOfWeek == DayOfWeek.Wednesday)
            {
                return 10;
            }
            if (dateToday.DayOfWeek == DayOfWeek.Sunday)
            {
                return 5;
            }

            return 0;
        }
    }
}
