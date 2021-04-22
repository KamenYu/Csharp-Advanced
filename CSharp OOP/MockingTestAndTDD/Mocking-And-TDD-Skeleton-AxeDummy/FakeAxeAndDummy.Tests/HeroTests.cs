using FakeAxeAndDummy.Contracts;
using Moq;
using NUnit.Framework;

[TestFixture]
public class HeroTests
{
    private Mock<IWeapon> weaponFake;
    private Mock<ITarget> dummyFake;
    private Axe ax;

    [SetUp]
    public void Setup()
    {
        weaponFake = new Mock<IWeapon>();
        dummyFake = new Mock<ITarget>();
        ax = new Axe(10, 10);
    }

    [Test]
    public void HeroShouldReceiveEXPWhenAttackedTargetDies()
    {
        //IWeapon axe = new Axe(10, 10);
        //ITarget dummy = new Dummy(10, 8);

        //IWeapon weaponFake = new IWeaponFake();
        //ITarget dummyFake = new ITargetFake();

        dummyFake.Setup(d => d.GiveExperience()).Returns(8);
        dummyFake.Setup(d => d.IsDead()).Returns(true);
        Hero hero = new Hero("K", weaponFake.Object);
        // here still the test is for the three classes
        // thus a failed test might be a mistake in any of the three classes
        hero.Attack(dummyFake.Object);
        // solution to that is Mock or Fake tests
        Assert.AreEqual(8, hero.Experience);
    }

    [Test]
    public void HeroEXP_AcruesWithEveryDeadTarget()
    {
        //Arrange
        Hero h = new Hero("N", weaponFake.Object);

        //Act
        dummyFake.Setup(e => e.GiveExperience()).Returns(30);
        dummyFake.Setup(d => d.IsDead()).Returns(true);
        h.Attack(dummyFake.Object);

        dummyFake.Setup(e => e.GiveExperience()).Returns(70);
        dummyFake.Setup(d => d.IsDead()).Returns(true);
        h.Attack(dummyFake.Object);

        int expectedExperience = 100;

        Assert.AreEqual(expectedExperience, h.Experience);
    }
}