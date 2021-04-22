using FizzBuzz.Contracts;
using Moq;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    public class Tests
    {
        //private FakeConsoleWriter writer;
        private Mock<IWriter> writer;
        private FizzBuzz fizzBuzz;
        private string result;

        [SetUp]
        public void Setup()
        {
            writer = new Mock<IWriter>();
            writer.Setup(w => w.WriteLine(It.IsAny<string>())).Callback<string>(i => result += i);
            fizzBuzz = new FizzBuzz(writer.Object);
            result = "";
        }

        [Test]
        public void WhenNumbersAre1and2ResultIsCorrect()
        {
            fizzBuzz.PrintNumbers(1, 2);
            Assert.AreEqual("12", result);
        }

        [Test]
        public void WhenNumbersAre2to4ResultIsCorrect()
        {
            fizzBuzz.PrintNumbers(2, 4);
            Assert.AreEqual("2Fizz4", result);
        }

        [Test]
        public void WhenNumbersAre4to6ResultIs_4BuzzFizz()
        {
            fizzBuzz.PrintNumbers(4, 6);
            Assert.AreEqual("4BuzzFizz", result);
        }

        [Test]
        public void WhenNumbersAre7to11ResultIs_78FizzBuzz11()
        {
            fizzBuzz.PrintNumbers(7, 11);
            Assert.AreEqual("78FizzBuzz11", result);
        }

        [Test]
        public void WhenNumbersAre14to17ResultIs_14FizzBuzz1617()
        {
            fizzBuzz.PrintNumbers(14, 17);
            Assert.AreEqual("14FizzBuzz1617", result);
        }

        [Test]
        public void WhenNumbersAreMInus5to2ResultIs_12()
        {
            fizzBuzz.PrintNumbers(-5, 2);
            Assert.AreEqual("12", result);
        }

        [Test]
        public void WhenNumbersAre25to30ResultIs_Buzz26Fizz2829FizzBuzz()
        {
            fizzBuzz.PrintNumbers(25, 30);
            Assert.AreEqual("Buzz26Fizz2829FizzBuzz", result);
        }

        [Test]
        public void WhenNumbersAre99to102ResultIs_FizzBuzz()
        {
            fizzBuzz.PrintNumbers(99, 102);
            Assert.AreEqual("FizzBuzz", result);
        }
    }
}