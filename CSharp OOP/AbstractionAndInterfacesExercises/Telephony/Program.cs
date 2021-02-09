using System;

namespace Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] possiblePhoneNums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] possibleWebSites = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            StationaryPhone stat = new StationaryPhone();
            Smartphone smart = new Smartphone();

            foreach (var num in possiblePhoneNums)
            {
                try
                {
                    if (num.Length == 7)
                    {                        
                        Console.WriteLine(stat.Calling(num));
                    }
                    else if(num.Length == 10)
                    {
                        Console.WriteLine(smart.Calling(num));
                    }
                    else
                    {
                        throw new ArgumentException(GlobalConstants.InvalidNumMsg);
                    }
                }
                catch (ArgumentException aex)
                {
                    Console.WriteLine(aex.Message);
                }               
            }

            foreach (var ws in possibleWebSites)
            {
                try
                {
                    Console.WriteLine(smart.Browsing(ws));
                }
                catch (ArgumentException aex)
                {
                    Console.WriteLine(aex.Message);
                }
            }
        }
    }
}
