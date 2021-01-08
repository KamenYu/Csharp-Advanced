using System;
using System.Collections.Generic;

namespace _4.CitiesByContinentsAndCountries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> log = new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();
                string contitent = line[0];
                string country = line[1];
                string city = line[2];

                if (log.ContainsKey(contitent) == false)
                {
                    log.Add(contitent, new Dictionary<string, List<string>>());
                    log[contitent].Add(country, new List<string>() { city });
                }
                else if (log[contitent].ContainsKey(country) == false)
                {
                    log[contitent].Add(country, new List<string>() { city });
                }
                else
                {
                    log[contitent][country].Add(city);
                }
            }

            foreach (var continent in log)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
