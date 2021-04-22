using System;
namespace _2_mountain_run
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSec = double.Parse(Console.ReadLine());
            double lenghtInMeters = double.Parse(Console.ReadLine());
            double secondsForOneMeter = double.Parse(Console.ReadLine());

            double seconds = lenghtInMeters * secondsForOneMeter;
            double slowing = Math.Floor(lenghtInMeters / 50);
            double slowing2 = slowing * 30;
            double totalSeconds = seconds + slowing2;
            double diff = Math.Abs(recordInSec - totalSeconds);

            if (totalSeconds < recordInSec)
            {
                Console.WriteLine($"Yes! The new record is {totalSeconds:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {diff:f2} seconds slower.");
            }
        }
    }
}
