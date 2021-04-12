﻿using System;
using System.Collections.Generic;
using System.Linq;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Repositories.Contracts;

namespace EasterRaces.Repositories.Entities
{
    public class RaceRepository :IRepository<IRace>
    {
        private readonly List<IRace> races;

        public RaceRepository()
        {
            races = new List<IRace>();
        }

        public void Add(IRace model)
            => races.Add(model);

        public IReadOnlyCollection<IRace> GetAll()
            => races.ToList();

        public IRace GetByName(string name)
            => races.FirstOrDefault(n => n.Name == name);

        public bool Remove(IRace model)
            => races.Remove(model);
    }
}
