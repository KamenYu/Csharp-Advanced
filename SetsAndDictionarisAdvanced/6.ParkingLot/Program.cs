using System;
using System.Collections.Generic;

namespace _6.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            HashSet<string> carReg = new HashSet<string>();

            while ((input = Console.ReadLine()) != "END")
            {
                string[] info = input.Split(", ");

                if (info[0] == "IN")
                {
                    carReg.Add(info[1]);
                }
                else
                {
                    carReg.Remove(info[1]);
                }
            }

            if (carReg.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var reg in carReg)
                {
                    Console.WriteLine(reg);
                }
            }
        }
    }
}
