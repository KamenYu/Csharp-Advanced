using System;
namespace _2.DateModifier
{
    public class DateModifier
    {
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public int DaysDifference (string startDate, string endDate)
        {
            DateTime start = DateTime.Parse(startDate);
            DateTime end = DateTime.Parse(endDate);
            return (int)(end - start).TotalDays;
        }
    }
}
