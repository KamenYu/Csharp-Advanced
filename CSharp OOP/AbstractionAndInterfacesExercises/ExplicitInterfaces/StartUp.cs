using System;
using System.Collections.Generic;
using ExplicitInterfaces.Interfaces;

namespace ExplicitInterfaces
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string line;
            List<Citizen> citizen = new List<Citizen>();

            while((line = Console.ReadLine()) != "End")
            {
                string[] tokens = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Citizen cit = new Citizen(tokens[0], tokens[1], int.Parse(tokens[2]));
                citizen.Add(cit);
            }

            foreach (var person in citizen)
            {
                IPerson iper = person;
                Console.WriteLine(iper.GetName());
                IResident ires = person;
                Console.WriteLine(ires.GetName());
            }
        }
    }
}
