using System;
using NUnit.Framework;

[TestFixture]
public class AxeTests
{
    [Test]
    [TestCase(100, 100, 20, 30, 29)] // hp, exp, attack, durability, expected
    [TestCase(34, 33, 12, 87, 86)] // this way I can add and make as many UT I desire
    public void WeaponShouldLoseDurabilityAfterAttack(
            int hp,
            int exp,
            int attack,
            int durability,
            int expected)
    {
        //Arrange
        Dummy dummy = new Dummy(hp, exp);
        Axe ax = new Axe(attack, durability);

        //Act
        ax.Attack(dummy);

        //Assert
        var actual = ax.DurabilityPoints;
        Assert.AreEqual(expected, actual);
    }

    [Test]
    [TestCase(10, 10, 30, 0)]
    public void AttackingWithABrokenWeaponShouldThrowInvalidOperationException(
        int hp,
        int exp,
        int attack,
        int durability)
    {
        //Arrange
        Dummy dummy = new Dummy(hp, exp);
        Axe ax = new Axe(attack, durability);

        //Act && Assert
        Assert.Throws<InvalidOperationException>(() => ax.Attack(dummy));
    }
}