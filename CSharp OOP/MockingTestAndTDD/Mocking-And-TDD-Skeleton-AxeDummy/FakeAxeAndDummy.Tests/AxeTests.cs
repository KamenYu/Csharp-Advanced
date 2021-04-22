using System;
using Moq;
using NUnit.Framework;

[TestFixture]
public class AxeTests
{
    private Mock<Dummy> dummy;
    private Axe ax;

    [SetUp]
    public void Setup()
    {
        dummy = new Mock<Dummy>();
    }

    [Test]
    public void AxeConstructorWorksProperly()
    {
        int expectedAttackPoints = 10;
        int expectedDurabilityPoints = 90;

        ax = new Axe(10, 90);

        Assert.AreEqual(expectedAttackPoints, ax.AttackPoints);
        Assert.AreEqual(expectedDurabilityPoints, ax.DurabilityPoints);
    }

    [Test]
    [TestCase(0)]
    [TestCase(-10)]
    public void WhenAttackingWithAxeIfDurabilityIsEqualOrBelowZeroThrowsIOE(int durability)
    {
        ax = new Axe(10, durability);

        Assert.Throws<InvalidOperationException>(() => ax.Attack(dummy.Object));
    }

    [Test]
    public void AfterSuccessfulAttackAxDurabilityDecreasesByOne()
    {
        //Arrange
        ax = new Axe(10, 10);

        //Act
        dummy.Setup(hp => hp.Health).Returns(20);
        ax.Attack(dummy.Object);

        //Assert
        Assert.AreEqual(9, ax.DurabilityPoints);
    }
}