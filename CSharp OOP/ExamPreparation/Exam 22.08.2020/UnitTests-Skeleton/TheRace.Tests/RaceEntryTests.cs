using System.Collections.Generic;
using NUnit.Framework;
using System;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        private RaceEntry re;
        private Dictionary<string, UnitDriver> dict;
        private UnitDriver driver;
        private UnitCar car;
        [SetUp]
        public void Setup()
        {
            dict = new Dictionary<string, UnitDriver>();
            car = new UnitCar("Bokol", 100, 1000);
            driver = new UnitDriver("Koko", car);
            re = new RaceEntry();
        }

        [Test]
        public void CtorSetsDict()
        {
            Dictionary<string, UnitDriver> dict = new Dictionary<string, UnitDriver>();

            Assert.IsEmpty(dict);
        }

        [Test]
        public void IfDriverNullThrowIOE()
        {
            Assert.Throws<InvalidOperationException>(() => re.AddDriver(null));
        }

        [Test]
        public void IfDriverExistsThrowIOE()
        {
            re.AddDriver(driver);
            Assert.Throws<InvalidOperationException>(() => re.AddDriver(driver));
        }

        [Test]
        public void AddMethodIncreasesCount()
        {
            Assert.AreEqual(0, dict.Count);
            dict.Add(driver.Name, driver);
            Assert.AreEqual(1, dict.Count);
        }

        [Test]
        public void AddMethodWorksWhenDataIsCorrect()
        {
            Assert.AreEqual("Driver Koko added in race.", re.AddDriver(driver));
        }

        [Test]
        public void IfDriversAreLessThanMINThrowsIOE()
        {
            re.AddDriver(driver);

            Assert.Throws<InvalidOperationException>(() => re.CalculateAverageHorsePower());
        }

        [Test]
        public void CalculateAverageHorsePowerWorksProperlyWhenDataIsCorrect()
        {
            re.AddDriver(driver);
            re.AddDriver(new UnitDriver("Kokolino", new UnitCar("modell", 90, 1200)));
            re.AddDriver(new UnitDriver("Mokolino", new UnitCar("modellL",110, 1200)));

            Assert.AreEqual(100, re.CalculateAverageHorsePower());
        }
    }
}