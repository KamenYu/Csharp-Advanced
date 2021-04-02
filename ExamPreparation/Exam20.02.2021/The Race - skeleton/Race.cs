using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        private List<Racer> data;
        public Race(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Racer>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return data.Count; } }

        public void Add(Racer racer)
        {
            if (data.Count < Capacity)
            {
                data.Add(racer); // or Racer
            }
        }

        public bool Remove(string name)
        {
            Racer r = data.Where(r => r.Name == name).FirstOrDefault();

            if (r == null)
            {
                return false;
            }
            else
            {
                data.Remove(r);
                return true;
            }
        }

        public Racer GetOldestRacer()
        {
            Racer oldest = data.OrderByDescending(x => x.Age).FirstOrDefault();
                return oldest;
        }

        public Racer GetRacer(string name)
        {
            Racer r = data.Where(r => r.Name == name).FirstOrDefault();
            return r;
        }

        public Racer GetFastestRacer()
        {
            Racer fastest = data.OrderByDescending(x => x.Car.Speed).FirstOrDefault();
            return fastest;
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Racers participating at {Name}:");

            foreach (var r in data)
            {
                result.AppendLine(r.ToString());
            }

            return result.ToString().Trim();
        }
    }
}
