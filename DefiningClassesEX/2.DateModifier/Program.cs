using System;

namespace _2.DateModifier
{
    public class Program
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            string end = Console.ReadLine();

            DateModifier days = new DateModifier();
            days.StartDate = start;
            days.EndDate = end;
            Console.WriteLine(Math.Abs(days.DaysDifference(start, end)));
        }
    }
}
