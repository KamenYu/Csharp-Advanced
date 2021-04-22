namespace Presents.Tests
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;
    using Presents;

    [TestFixture]
    public class PresentsTests
    {

        private Present p;
        private Bag bag;

        [SetUp]
        public void Setup()
        {
            p = new Present("P", 100.00);
            bag = new Bag();
        }

        [Test]
        public void PresentCtorWorks()
        {
            Assert.IsNotNull(p);
        }

        [Test]
        public void PresentPropsWork()
        {
            Assert.AreEqual("P", p.Name);
            Assert.AreEqual(100.00, p.Magic);
        }



        [Test]
        public void BagCreatesPresentCorrect()
        {
            bag.Create(p);
            Present expected = bag.GetPresent("P");
            Assert.AreEqual(expected, p);
        }
        [Test]
        public void FalseRemove()
        {
            Assert.IsFalse(bag.Remove(p));
        }

        [Test]
        public void TrueRemove()
        {
            bag.Create(p);
            Assert.IsTrue(bag.Remove(p));
        }

        [Test]
        public void IfPresentNull_AE()
        {
            p = null;
            Assert.Throws<ArgumentNullException>(() => bag.Create(p));
        }

        [Test]
        public void IfPresentSame_IOE()
        {
            bag.Create(p);
            Assert.Throws<InvalidOperationException>(() => bag.Create(p));
        }

        [Test]
        public void GetPresentWithLeastMagicWorks()
        {
            Present expected = new Present("R", 10.00);
            bag.Create(p);
            bag.Create(expected);
            bag.Create(new Present("E", 12.00));
            bag.Create(new Present("S", 30008.00));
            Assert.AreEqual(expected, bag.GetPresentWithLeastMagic());
        }

        [Test]
        public void GetPresentWorks()
        {
            Present expected = new Present("R", 10.00);
            bag.Create(p);
            bag.Create(expected);
            bag.Create(new Present("E", 12.00));
            bag.Create(new Present("S", 30008.00));
            Assert.AreEqual(expected, bag.GetPresent("R"));
        }

        [Test]
        public void GetPresentsCollectionWorks()
        {
            List<Present> presents = new List<Present>();
            presents.Add(p);

            bag.Create(p);

            CollectionAssert.AreEqual(presents, bag.GetPresents());
        }
    }
}
