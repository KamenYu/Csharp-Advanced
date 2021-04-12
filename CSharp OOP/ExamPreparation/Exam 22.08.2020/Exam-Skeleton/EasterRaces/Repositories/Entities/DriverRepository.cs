using System.Collections.Generic;
using System.Linq;

using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Repositories.Contracts;

namespace EasterRaces.Repositories.Entities
{
    public class DriverRepository : IRepository<IDriver>
    {
        private readonly List<IDriver> drivers;
        public DriverRepository()
        {
            drivers = new List<IDriver>();
        }       

        public void Add(IDriver model)
            => drivers.Add(model);

        public IReadOnlyCollection<IDriver> GetAll()
            => drivers.ToList();

        public IDriver GetByName(string name)
            => drivers.FirstOrDefault(n => n.Name == name);

        public bool Remove(IDriver model)
            => drivers.Remove(model);
    }
}
