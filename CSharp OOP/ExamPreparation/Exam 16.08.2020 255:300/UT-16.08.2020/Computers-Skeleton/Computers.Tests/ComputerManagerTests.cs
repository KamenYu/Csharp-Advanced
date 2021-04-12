using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Computers.Tests
{
    public class Tests
    {
        private ComputerManager manager;
        private Computer privateComp;
        [SetUp]
        public void Setup()
        {
            manager = new ComputerManager();
            privateComp = null;
        }

        [Test]
        public void IsNullCompNull()
        {
            Assert.IsNull(privateComp);
            Assert.Throws<ArgumentNullException>(() => manager.AddComputer(privateComp));
        }

        [Test]
        public void IfCompExistsThrowsAE()
        {
            privateComp = new Computer("K", "L", 200);
            manager.AddComputer(privateComp);
            Assert.Throws<ArgumentException>(() => manager.AddComputer(privateComp));
        }

        [Test]
        public void AddingACompIncreasesCount()
        {
            Assert.AreEqual(0, manager.Computers.Count);
            privateComp = new Computer("K", "L", 200);
            manager.AddComputer(privateComp);
            Assert.AreEqual(1, manager.Count);
        }

        [Test]
        public void RemoveCompDecreasesCountByOne()
        {
            manager.AddComputer(new Computer("M", "No", 900));
            manager.AddComputer(new Computer("L", "S", 9000));
            Assert.AreEqual(2, manager.Computers.Count);
            manager.RemoveComputer("L", "S");
            Assert.AreEqual(1, manager.Computers.Count);
        }

        [Test]
        public void RemovedCompAndCompAreSame()
        {
            manager.AddComputer(new Computer("M", "No", 900));
            Computer expected = new Computer("L", "S", 9000);
            manager.AddComputer(expected);

            Computer removed = manager.RemoveComputer("L", "S");
            Assert.AreSame(expected, removed);
        }

        [Test] // 4 // 9
        public void RemovingNullCompThrowsAE()
        {
            Assert.Throws<ArgumentException>(() => manager.RemoveComputer("2", "ko"));
        }

        [Test]
        public void GetCompThrowsANEIfManufIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => manager.GetComputer(null, "model"));
        }

        [Test]
        public void GetCompThrowsANEIfModelIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => manager.GetComputer("Man", null));
        }

        [Test]
        public void GetCompThrowsAEIfCompIsNull()
        {
            Assert.Throws<ArgumentException>(() => manager.GetComputer("K", "Supa"));
        }

        [Test]
        public void GetCompReturnsComp()
        {
            Computer comp1 = new Computer("1", "00", 900);
            Computer comp2 = new Computer("M", "KL", 1200);

            manager.AddComputer(comp1);
            manager.AddComputer(comp2);

            Assert.AreSame(comp2, manager.GetComputer("M", "KL"));
        }

        [Test]
        public void GetComputersByManufacturerIfManNullThrowsANE()
        {
            Assert.Throws<ArgumentNullException>(() => manager.GetComputersByManufacturer(null));
        }

        [Test] // 2
        public void GetComputersByManufacturerReturnsCollection()
        {
            Computer comp1 = new Computer("1", "00", 900);
            Computer comp2 = new Computer("1", "KL", 1200);
            Computer comp3 = new Computer("2", "KL", 1200); // this

            manager.AddComputer(comp1);
            manager.AddComputer(comp2);
            manager.AddComputer(comp3);

            List<Computer> expected = new List<Computer>() { comp1, comp2 };
            CollectionAssert.AreEqual(expected, manager.GetComputersByManufacturer("1"));
        }
    }
}