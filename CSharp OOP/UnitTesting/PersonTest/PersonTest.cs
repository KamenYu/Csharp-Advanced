using System;
using Demo1;
using NUnit.Framework;

namespace DemoTest1
{
    [TestFixture] // VERY IMPORTANT
    public class PersonTest
    {
        public Person person;

        [SetUp] // this is to initialize all the entities on the beginnnig, thus removing the Arrange step
        public void Initialize()
        // this is not necessary, however,
        // when having a [Setup] I need a [TearDown] in the end to tear down what was created 
        {
            person = new Person("", 0);
        }

        [Test] // VERY IMPORTANT
        [TestCase("Kamen")]
        [TestCase("LolitaPura")]
        [TestCase("Nevimedeznigor")] // instread of using for cycle        
        public void DoesWhatIsMyNameWork(string name)
        {
            //Arrange
            person = new Person(name, 10);

            // Act
            string expectedResult = $"My name is {name}";
            string actualResult = person.WhatIsMyName();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestingAssert()
        {
            person = new Person("Nadya", 88343);
            int a = 5;
            int b = -5;
            string c = string.Empty;
            //Assert.AreEqual(a, b);
            //Assert.False(a == b);
            Assert.Greater(a, b);
            //Assert.IsEmpty(c);
            //Assert.That(a > b);
            //Assert.Throws<ArgumentException>(() => p.WhatIsMyName());
            //Assert.AreEqual(88343, person.SavedMoney);
        }

        [Test]
        public void FileExists()
        {
            Assert.That("/Users/kamenyu/Downloads/07. CSharp-OOP-SOLID-Exercise.docx", Does.Exist, "The searched file does not exist");
        }

        [TearDown]
        public void Demolish()
        {
            person = null; // I have no idea if this is correct
        }
    }
}