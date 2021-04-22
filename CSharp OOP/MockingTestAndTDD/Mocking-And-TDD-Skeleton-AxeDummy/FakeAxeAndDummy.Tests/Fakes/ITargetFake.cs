using FakeAxeAndDummy.Contracts;

namespace FakeAxeAndDummy.Tests.Fakes
{
    public class ITargetFake : ITarget
    {
        public int Health {get ;} // no need for hp

        public int GiveExperience()
        {
            return 8; // important for the pertinent test
        }

        public bool IsDead()
        {
            return true; // no need to know when is dead
        }

        public void TakeAttack(int attackPoints)
        {
            // no need to decrease hp when attacked
        }
    }
}
