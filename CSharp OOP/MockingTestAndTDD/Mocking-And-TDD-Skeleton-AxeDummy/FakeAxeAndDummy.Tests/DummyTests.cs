using System;
using NUnit.Framework;

[TestFixture]
public class DummyTests
{
    private Dummy dummy;

    [Test]
    public void DummyConstructorWorksProperly()
    {
        int expectedHP = 0;
        int expectedEXP = 30;

        dummy = new Dummy(0, 30);

        Assert.AreEqual(expectedHP, dummy.Health);
        Assert.AreEqual(expectedEXP, dummy.GiveExperience());
    }

    [Test]
    public void IfDummyIsDead_TakeAttackThrowsIOE()
    {
        dummy = new Dummy(0, 30);
        Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(1));
    }

    [Test]
    public void IfDummyIsNotDead_TakeAttackDecreasesHealthByAttackerAttackPoints()
    {
        //Arrange
        dummy = new Dummy(100, 30);

        //Act
        dummy.TakeAttack(30);
        int expectedHealth = 70;

        //Assert
        Assert.AreEqual(expectedHealth, dummy.Health);
    }

    [Test]
    public void WhenGiveExperienceIsCalled_ThrowsIOE_IfAlive()
    {
        dummy = new Dummy(100, 30);
        Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
    }

    [Test]
    public void DummyGivesEXPOnlyWhenDead()
    {
        dummy = new Dummy(0, 30);

        int expectedEXP = 30;
        Assert.AreEqual(expectedEXP, dummy.GiveExperience());
    }

    [Test]
    [TestCase(0)]
    [TestCase(-2)]
    public void DummyIsDeadWhenHealthIsEqualOrBelowZero(int hp)
    {
        dummy = new Dummy(hp, 30);
        Assert.IsTrue(dummy.IsDead());
    }
}