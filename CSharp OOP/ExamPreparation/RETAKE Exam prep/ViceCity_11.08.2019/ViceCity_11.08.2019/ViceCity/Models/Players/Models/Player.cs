using System;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Players.Contracts;
using ViceCity.Repositories.Contracts;
using ViceCity.Repositories.Models;

namespace ViceCity.Models.Players.Models
{
    public abstract class Player : IPlayer
    {
        private string name;
        private int lifePoints;
        public IRepository<IGun> gunRepository;

        protected Player(string name, int lifePoints)
        {
            Name = name;
            LifePoints = lifePoints;
            gunRepository = new Repository();
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(Player),"Player's name cannot be null or whitespace!");
                }

                name = value;
            }
        }

        public bool IsAlive => LifePoints > 0;

        public IRepository<IGun> GunRepository { get { return gunRepository; } }

        public int LifePoints
        {
            get { return lifePoints; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Player life points cannot be below zero!");
                }

                lifePoints = value;
            }
        }

        public void TakeLifePoints(int points)
        {
            lifePoints -= points;

            if (lifePoints < 0)
            {
                lifePoints = 0;
            }
        }
    }
}
