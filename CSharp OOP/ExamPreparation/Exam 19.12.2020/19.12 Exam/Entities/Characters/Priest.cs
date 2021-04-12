using System;
using WarCroft.Constants;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Inventory;

namespace WarCroft.Entities.Characters
{
    public class Priest : Character, IHealer
    {
        private const double baseHealth = 50;
        private const double baseArmour = 25;
        private const double abilityPoints = 40;
        public Priest(string name)
            : base(name, baseHealth, baseArmour, abilityPoints, new Backpack() )
        { }

        public void Heal(Character character)
        {
            EnsureAlive();

            if (character.IsAlive == false)
            {
                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }

            character.Health += this.AbilityPoints;
        }
    }
}
