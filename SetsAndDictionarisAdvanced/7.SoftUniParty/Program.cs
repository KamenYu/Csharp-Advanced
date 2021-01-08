using System;
using System.Collections.Generic;

namespace _7.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> VIP = new HashSet<string>();
            HashSet<string> regulars = new HashSet<string>();
            string input;

            while ((input = Console.ReadLine()) != "PARTY")
            {
                char[] reservation = input.ToCharArray();
                if (char.IsDigit(reservation[0]))
                {
                    VIP.Add(input);
                }
                else
                {
                    regulars.Add(input);
                }                
            }

            while ((input = Console.ReadLine()) != "END")
            {
                char[] arrived = input.ToCharArray();

                if (char.IsDigit(arrived[0]))
                {
                    VIP.Remove(input);
                }
                else
                {
                    regulars.Remove(input);
                }
            }

            Console.WriteLine(VIP.Count + regulars.Count);
            foreach (var guest in VIP)
            {
                Console.WriteLine(guest);
            }
            foreach (var regular in regulars)
            {
                Console.WriteLine(regular);
            }
        }
    }
}
