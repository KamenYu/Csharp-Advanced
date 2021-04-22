using System;
using PlayersAndMonsters.Models.Players.Contracts;
using PlayersAndMonsters.Repositories.Contracts;

namespace PlayersAndMonsters.Models.Players
{
    public abstract class Player : IPlayer
    {
        private string name;
        private int health;

        protected Player(ICardRepository cardRepo, string name, int health)
        {
            Username = name;
            Health = health;
            CardRepository = cardRepo;
        }

        public ICardRepository CardRepository { get; }

        public string Username
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Player's name cannot be null or an empty string.");
                }

                name = value;
            }
        }

        public int Health
        {
            get { return health; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Player's health cannot be less than zero.");
                }

                health = value;
            }
        }

        public bool IsDead => Health < 0;  // =

        public void TakeDamage(int damagePoints)
        {
            if (damagePoints < 0)
            {
                throw new ArgumentException("Damage points cannot be less than zero");
            }

            Health = Math.Max(Health - damagePoints, 0);
        }
    }
}
