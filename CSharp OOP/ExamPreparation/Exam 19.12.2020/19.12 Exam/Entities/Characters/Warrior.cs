using System;
using WarCroft.Constants;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Inventory;

namespace WarCroft.Entities.Characters
{
    public class Warrior : Character, IAttacker
    {
        private const double baseHealth = 100;
        private const double baseArmour = 50;
        private const double abilityPoints = 40;

        public Warrior(string name)
            : base(name, baseHealth, baseArmour, abilityPoints, new Satchel())
        {
        }

        public void Attack(Character character)
        {
            EnsureAlive();

            if (this.Name == character.Name)
            {
                throw new InvalidOperationException("Cannot attack self!");
            }

            if (character.IsAlive == false)
            {
                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }

            character.TakeDamage(this.AbilityPoints);
        }
    }
}
