namespace Raiding
{
    public class Paladin : BaseHero
    {
        public Paladin(string name) : base(name)
        { }

        public override int Power { get { return 100; } }

        public override string CastAbility()
        {
            return $"Paladin - {Name} healed for {Power}";
        }
    }
}
