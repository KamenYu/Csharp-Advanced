using System;
using System.Collections.Generic;
using System.Linq;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Repositories.Contracts;

namespace ViceCity.Repositories.Models
{
    public class Repository : IRepository<IGun>
    {
        private List<IGun> guns;
        public Repository()
        {
            guns = new List<IGun>();
        }

        public IReadOnlyCollection<IGun> Models => guns.AsReadOnly();

        public void Add(IGun model)
            => guns.Add(model);

        public IGun Find(string name)
            => guns.FirstOrDefault(x => x.Name == name);

        public bool Remove(IGun model)
            => guns.Remove(model);
    }
}
