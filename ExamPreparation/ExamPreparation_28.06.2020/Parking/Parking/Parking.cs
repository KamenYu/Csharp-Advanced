using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private List<Car> data;
        public Parking(string type,int capacity)
        {
            Type = type;
            Capacity = capacity;
            data = new List<Car>();
        }

        public string Type { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return data.Count; } }

        public void Add(Car car)
        {
            if (data.Count < Capacity)
            {
                data.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            Car car = data.FirstOrDefault(n => n.Manufacturer == manufacturer && n.Model == model);

            if (car == null)
            {
                return false;
            }

            return true;
        }

        public Car GetLatestCar()
        {
            Car latest = data.OrderByDescending(y => y.Year).FirstOrDefault();
            return latest;
        }

        public Car GetCar(string manufacturer, string model)
        {
            Car car = data.FirstOrDefault(n => n.Manufacturer == manufacturer && n.Model == model);
            return car;
        }

        public string GetStatistics()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"The cars are parked in {Type}:");

            foreach (Car car in data)
            {
                result.AppendLine($"{car}");
            }

            return result.ToString().Trim();
        }
    }
}
