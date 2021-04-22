using System;
using NUnit.Framework;

[TestFixture]
public class DummyTests
{
    [Test]
    [TestCase(100, 35, 24, 34, 76)]
    [TestCase(100, 35, 10, 34, 90)]
    public void DummyLosesHealthIfAttacked(
        int hp,
        int exp,
        int attack,
        int durabulity,
        int expected)
    {
        //Arrange
        Dummy d = new Dummy(hp, exp);
        Axe ax = new Axe(attack, durabulity);

        //Act
        ax.Attack(d);
        int actualHealth = d.Health;

        //Assert
        Assert.AreEqual(expected, actualHealth);
    }

    [Test]
    [TestCase(1, 35, 2, 34)]
    [TestCase(1, 35, 1, 34)]
    public void DeadDummyThrowsExceptionIfAttacked(
        int hp,
        int exp,
        int attack,
        int durabulity)
    {
        //Arrange
        Dummy d = new Dummy(hp, exp);
        Axe ax = new Axe(attack, durabulity);

        //Act
        ax.Attack(d);

        //Assert
        Assert.Throws<InvalidOperationException>(() => ax.Attack(d));
    }

    [Test]
    [TestCase(0, 2, 2)]
    [TestCase(-2, 4, 4)]
    public void DeadDummyCanGiveXP(int hp, int exp, int expectedEXP)
    {
        //Arrange
        Dummy d = new Dummy(hp, exp);

        //Act
        int actualEXP = d.GiveExperience();

        //Assert
        Assert.AreEqual(expectedEXP, actualEXP);
    }

    [Test]
    [TestCase(30, 4)]
    [TestCase(1, 4)]
    public void AliveDummyCannotGiveXP(int hp, int exp)
    {
        //Arrange
        Dummy d = new Dummy(hp, exp);

        //Act && Assert
        Assert.Throws<InvalidOperationException>(() => d.GiveExperience());
    }
}