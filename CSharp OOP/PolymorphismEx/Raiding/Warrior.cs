﻿namespace Raiding
{
    public class Warrior : BaseHero
    {
        public Warrior(string name) : base(name)
        { }

        public override int Power { get { return 100; } }

        public override string CastAbility()
        {
            return $"Warrior - {Name} hit for {Power} damage";
        }
    }
}
