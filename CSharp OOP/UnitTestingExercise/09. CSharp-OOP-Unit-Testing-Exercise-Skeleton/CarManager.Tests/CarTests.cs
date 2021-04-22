using System;
using NUnit.Framework;

namespace Tests
{
    public class CarTests
    {
        // AE => Argument Exception


        [Test]
        [TestCase("Peugeot", "307", 7.894, 60.25)]
        [TestCase("BMW", "3", 15, 200.50)]
        public void CarConstructorSetsAllParametersProperly(
            string make,
            string model,
            double fuelConsumption,
            double fuelCapacity)
        {
            //Arrange && Act
            Car car = new Car(
                make: make,
                model: model,
                fuelConsumption: fuelConsumption,
                fuelCapacity: fuelCapacity);

            //Assert
            Assert.AreEqual(car.Make, make);
            Assert.AreEqual(car.Model, model);
            Assert.AreEqual(car.FuelConsumption, fuelConsumption);
            Assert.AreEqual(car.FuelCapacity, fuelCapacity);
            Assert.AreEqual(car.FuelAmount, 0);
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void CarConstructorThrowsAEWhenMakeIsNullOrEmpty(string make)
        {
            //Arrange && Act && Assert
            Assert.Throws<ArgumentException>(() => new Car(make, "Lolo", 1, 4));
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void CarConstructorThrowsAEWhenModelIsNullOrEmpty(string model)
        {
            //Arrange && Act && Assert
            Assert.Throws<ArgumentException>(() => new Car("Gihi", model, 1, 4));
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        public void CarConstructorThrowsAEWhenFuelConsumptionIsEqualOrBelowZero
            (double fuelConsumptiuon)
        {
            //Arrange && Act && Assert
            Assert.Throws<ArgumentException>(() => new Car("Gihi", "Guhu", fuelConsumptiuon, 1));
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        public void CarConstructorThrowsAEWhenFuelCapacityIsEqualOrBelowZero
           (double fuelCapacity)
        {
            //Arrange && Act && Assert
            Assert.Throws<ArgumentException>(() => new Car("Gihi", "Guhu", 1, fuelCapacity));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void RefuelThrowsAEWhenFuelToRefuelIsEqualOrBelowZero
           (double amount)
        {
            //Arrange
            Car car = new Car("A", "B", 10, 100);

            //Act && Arrange
            Assert.Throws<ArgumentException>(() => car.Refuel(amount));
        }

        [Test]
        [TestCase(100, 50, 50)]
        [TestCase(100, 300, 100)]
        public void RefuelShouldWorkAsExpected(double fuelCapacity, double fuel, double result)
        {
            //Arrange
            Car car = new Car("A", "B", 10, fuelCapacity);

            //Act
            car.Refuel(fuel);
            var actualResult = car.FuelAmount;

            //Assert
            Assert.AreEqual(result, actualResult);
        }

        [Test]
        [TestCase(10, 50, 501.9)]
        [TestCase(15, 30, 201)]
        public void DriveThrowsIOPWhenFuelIsNotEnough(
            double fuelConsumption,
            double refuel,
            double km)
        {
            //Arrange
            Car car = new Car("A", "B", fuelConsumption, 100);
            car.Refuel(50);

            //Act && Assert
            Assert.Throws<InvalidOperationException>(() => car.Drive(501));
        }

        [Test]
        [TestCase(10, 100, 50, 95)]
        public void DriveShouldReduceFuelBasedOnDrivenKm(
            double fuelConsumption, double fuel, double km, double amountLeft)
        {
            //Arrange
            Car car = new Car("A", "B", fuelConsumption, 100);
            car.Refuel(fuel);

            //Act
            car.Drive(km);

            double actual = car.FuelAmount;

            //Assert
            Assert.AreEqual(amountLeft, actual);
        }
    }
}