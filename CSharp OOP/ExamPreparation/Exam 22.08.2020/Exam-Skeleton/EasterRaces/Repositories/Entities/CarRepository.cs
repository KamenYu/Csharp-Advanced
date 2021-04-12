using System.Collections.Generic;
using System.Linq;
 
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Repositories.Contracts;

namespace EasterRaces.Repositories.Entities
{
    public class CarRepository : IRepository<ICar>
    {
        private readonly List<ICar> cars; // same name => no need
        public CarRepository()
        {
            cars = new List<ICar>();
        }

        public void Add(ICar model)
            => cars.Add(model);

        public IReadOnlyCollection<ICar> GetAll()
            => cars.ToList();

        public ICar GetByName(string name)
            => cars.FirstOrDefault(n => n.Model == name);

        public bool Remove(ICar model)
            => cars.Remove(model);
    }
}
