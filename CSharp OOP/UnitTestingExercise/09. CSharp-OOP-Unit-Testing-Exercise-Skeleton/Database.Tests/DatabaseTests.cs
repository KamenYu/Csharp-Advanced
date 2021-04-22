using System.Linq;
using System;
using NUnit.Framework;

public class DatabaseTests
{
    [SetUp]
    public void Setup()
    {
    }
    // int[] numbers = Enumarable.Range(startIndex, endIndex).ToArray();

    [Test]
    [TestCase(1,16,16)]
    [TestCase(1,3,3)]
    public void TestIfInitialArrayHoldsUpTo16Elements(
        int startIndex,
        int endIndex,
        int expectedCount)
    {
        //Arrange
        int[] numbers = Enumerable.Range(startIndex, endIndex).ToArray();
        Database db = new Database(numbers); // although it is invalid for compile time this is what is needed for Judge

        //Act
        int actualCount = db.Count;

        //Assert
        Assert.AreEqual(expectedCount, actualCount);
    }

    [Test]
    public void TestIfInitialArrayThrowsInvalidOperationExceptionWhenAdding17thElement()
    {
        //Arrange
        int[] numbers = Enumerable.Range(1, 16).ToArray();
        Database db = new Database(numbers);

        //Act && Assert
        Assert.Throws<InvalidOperationException>(() => db.Add(87));
    }

    [Test]
    public void AddOperationShouldAddElementAtNextFreeCell()
    {
        //Arrange
        int[] numbers = Enumerable.Range(1, 5).ToArray();
        Database db = new Database(numbers);

        //Act
        db.Add(76);
        int expectedCount = 6;
        int actualCount = db.Count;

        int expectedElement = 76;
        int actualElement = db.Fetch()[5];

        //Assert
        Assert.AreEqual(expectedCount, actualCount);
        Assert.AreEqual(expectedElement, actualElement);
    }

    [Test]
    public void RemoveOperationShouldRemoveAtLastIndex()
    {
        //Arrange
        int[] numbers = Enumerable.Range(1, 5).ToArray();
        Database db = new Database(numbers);

        //Act
        db.Remove();
        int expectedCount = 4;
        int actualCount = db.Count;

        int expectedElement = 4;
        int actualElement = db.Fetch()[actualCount - 1];

        Assert.AreEqual(expectedCount, actualCount);
        Assert.AreEqual(expectedElement, actualElement);
    }

    [Test]
    public void RemovingAnElementFromEmptyDBShouldThrowIOE()
    {
        //Arrange
        Database db = new Database();

        //Act && Assert
        Assert.Throws<InvalidOperationException>(() => db.Remove());
    }

    [Test]
    public void FetchShouldRerturnAllElements()
    {
        //Arrange
        int[] numbers = Enumerable.Range(1, 5).ToArray();
        Database db = new Database(numbers);

        //Act
        int[] actual = db.Fetch();
        int[] expected = { 1, 2, 3, 4, 5 };

        //Assert
        CollectionAssert.AreEqual(expected, actual);
    }
}
