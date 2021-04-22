using System;
using NUnit.Framework;

namespace BlueOrigin.Tests
{
    [TestFixture]
    public class SpaceshipTests
    {
        private Spaceship s;
        private Astronaut a;
        private Astronaut ast;

        [SetUp]
        public void Setup()
        {
            s = new Spaceship("Rub", 123);
            a = new Astronaut("Lqv", 45);
            ast = new Astronaut("Desen", 80);
        }

        [Test]
        public void TestCtor()
        {
            Assert.IsNotNull(s);
        }


        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void TestNameNullOrEmpty_ANE(string name)
        {
            Assert.Throws<ArgumentNullException>(() => new Spaceship(name, 90));
        }

        [Test]
        public void TestNameCorrectData()
        {
            Assert.AreEqual("Rub", s.Name);
        }

        [Test]
        public void TestCapacityBelowZero_AE()
        {
            Assert.Throws<ArgumentException>(() => new Spaceship("J", -1));
        }

        [Test]
        public void TestCapacityCorrectData()
        {
            Assert.AreEqual(123, s.Capacity);
        }

        [Test]
        public void TestCount_And_AddRemoveWithValidData()
        {
            Assert.AreEqual(0, s.Count);
            s.Add(a);
            s.Add(ast);
            Assert.AreEqual(2, s.Count);
            s.Remove("Desen");
            Assert.AreEqual(1, s.Count);
        }

        [Test]
        public void TestAddCountEqualsCapacity_IOE()
        {
            s = new Spaceship("K", 0);
            Assert.Throws<InvalidOperationException>(() => s.Add(a));
        }


        [Test]
        public void TestAddAddingSameAstronaut_IOE()
        {
            s.Add(a);
            Assert.Throws<InvalidOperationException>(() => s.Add(a));
        }

        [Test]
        public void TestRemoveIfAstroExists_True()
        {
            s.Add(a);
            Assert.IsTrue(s.Remove("Lqv"));
        }

        [Test]
        public void TestRemoveIfAstroDoesNOTExist_False()
        {
            Assert.IsFalse(s.Remove("Lqv"));
        }
    }
}