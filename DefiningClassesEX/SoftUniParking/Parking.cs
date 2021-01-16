using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> cars;
        private int capacity;

        public Parking(int capacity)
        {
            this.capacity = capacity;
            cars = new List<Car>();
        }

        public int Count => cars.Count();

        public string AddCar(Car car)
        {
            if (cars.Any(x => x.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            else if (cars.Count >= capacity)
            {
                return "Parking is full!";
            }
            else
            {
                cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }

        public string RemoveCar(string regNumber)
        {
            if (cars.Any(x => x.RegistrationNumber == regNumber) == false)
            {
                return "Car with that registration number, doesn't exist!";
            }
            else
            { 
                cars.Remove(cars.FirstOrDefault(x => x.RegistrationNumber == regNumber));
                return $"Successfully removed {regNumber}";
            }
        }

        public Car GetCar(string regNumber)
        {
            return cars.FirstOrDefault(x => x.RegistrationNumber == regNumber);
        }

        public void RemoveSetOfRegistrationNumber(List<string> regNumbers)
        {
            foreach (var regNumber in regNumbers)
            {
                cars.RemoveAll(x => x.RegistrationNumber == regNumber);
            }
        }
    }
}
