using System;

using WarCroft.Constants;
using WarCroft.Entities.Inventory;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Characters.Contracts
{
    public abstract class Character
    {
		private string name;
		private double health;
		private double armor;

        public Character(string name, double health, double armor, double abilityPoints, Bag bag)
        {
            Name = name;
            BaseHealth = health;
            Health = health;
            BaseArmor = armor;
            Armor = armor;
            AbilityPoints = abilityPoints;
            Bag = bag;
        }

		public string Name
        {
            get { return name; }
			private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or whitespace!");
                }

                name = value;
            }
        }

        public double BaseHealth
        { get; private set; }

		public double Health
        {
            get { return health; }
			set
            {
                if (value >= 0 && value <= BaseHealth)
                {
                    health = value;
                }
            }
        }

        public virtual double BaseArmor
        { get; private set; }

        public  double Armor
        {
            get { return armor; }
            private set
            {
                if (value >= 0)
                {
                    armor = value;
                }
                else
                {
                    armor = 0;
                }
                
            }
        }

        public virtual double AbilityPoints { get; private set; }

        public virtual Bag Bag { get; private set; }

        public bool IsAlive { get; set; } = true;


		protected void EnsureAlive()
		{
			if (!this.IsAlive)
			{
				throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
			}
		}

        public void TakeDamage(double hitPoints)
        {
            EnsureAlive();

            if (hitPoints > Armor)
            {
                hitPoints -= Armor;
                Armor = 0;

                if (hitPoints > Health)
                {
                    IsAlive = false;
                    Health = 0;

                }
                else
                {
                    Health -= hitPoints;
                }
            }
            else
            {
                Armor -= hitPoints;
            }          
        }

        public void UseItem(Item item)
        {
            if (IsAlive)
            {
                item.AffectCharacter(this);
            }
        }

    }
}