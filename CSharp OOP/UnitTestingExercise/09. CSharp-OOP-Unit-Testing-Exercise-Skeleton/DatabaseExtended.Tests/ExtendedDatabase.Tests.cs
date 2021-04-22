using System;
using NUnit.Framework;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        // IOE => Invalid Operations Exception
        // ANE => Argument Null Exception
        // AOORE => ArgumentOutOfRangeException

        [Test]
        public void TestIfInitialArrayHoldsUpTo16Elements()
        {
            //Arrange
            ExtendedDatabase db = new ExtendedDatabase
                (new Person[16]
            {
                new Person(1, "AA"),
                new Person(2, "AB"),
                new Person(3, "AC"),
                new Person(4, "AD"),
                new Person(5, "AE"),
                new Person(6, "AF"),
                new Person(7, "AG"),
                new Person(8, "AH"),
                new Person(9, "AI"),
                new Person(10, "AJ"),
                new Person(11, "AK"),
                new Person(12, "AL"),
                new Person(13, "AM"),
                new Person(14, "AN"),
                new Person(15, "AO"),
                new Person(16, "AP")
            });

            //Act
            int actualCount = db.Count;
            int expectedCount = 16;

            //Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void TestIfInitialArrayThrowsInvalidOperationExceptionWhenAdding17thElement()
        {
            //Arrange
            ExtendedDatabase db = new ExtendedDatabase(new Person[16]
            {
                new Person(1, "AA"),
                new Person(2, "AB"),
                new Person(3, "AC"),
                new Person(4, "AD"),
                new Person(5, "AE"),
                new Person(6, "AF"),
                new Person(7, "AG"),
                new Person(8, "AH"),
                new Person(9, "AI"),
                new Person(10, "AJ"),
                new Person(11, "AK"),
                new Person(12, "AL"),
                new Person(13, "AM"),
                new Person(14, "AN"),
                new Person(15, "AO"),
                new Person(16, "AP")
            });

            //Act && Assert
            Assert.Throws<InvalidOperationException>(() => db.Add(new Person(23, "K")));
        }

        [Test]
        public void AddOperationShouldIncreaseCountBy1()
        {
            //Arrange
            var people = new Person[2]
            {
                new Person(22, "ND"),
                new Person(30, "KY")
            };

            ExtendedDatabase db = new ExtendedDatabase(people);

            //Act
            db.Add(new Person(21, "PD"));
            int expectedCount = 3;
            int actualCount = db.Count;

            //Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void ThrowsIOEWhenAddingAUserWithTheSameUsername()
        {
            //Arrange
            ExtendedDatabase db = new ExtendedDatabase
                (new Person[]
                {
                    new Person(34, "V"),
                    new Person(90, "M")
                });

            //Act && Assert
            Assert.Throws<InvalidOperationException>(() => db.Add(new Person(98, "V")));
        }

        [Test]
        public void ThrowsIOEWhenAddingAUserWithTheSameID()
        {
            //Arrange
            ExtendedDatabase db = new ExtendedDatabase
                (new Person[]
                {
                    new Person(34, "V"),
                    new Person(90, "M")
                });

            //Act && Assert
            Assert.Throws<InvalidOperationException>(() => db.Add(new Person(34, "J")));
        }

        [Test]
        public void AreEntitiesPlacedCorrectlyInsideArray()
        {
            //Arrange
            ExtendedDatabase db = new ExtendedDatabase
            (new Person[]
            {
                new Person(34, "V"),
                new Person(90, "M"),
                new Person(998, "J")
            });

            //Act
            db.Add(new Person(0987000, "Kolp"));
            int expectedIndex = 3;
            int actualIndex = db.Count - 1;

            //Assert
            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [Test]
        public void RemovingAnElementShouldDecresaseCountByOne()
        {
            //Arrange
            var people = new Person[2]
            {
                new Person(22, "ND"),
                new Person(30, "KY")
            };

            ExtendedDatabase db = new ExtendedDatabase(people);

            //Act
            db.Remove();
            int expectedCount = 1;
            int actualCount = db.Count;

            //Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void RemovingAnElementFromEmptyDBShouldThrowIOE()
        {
            //Arrange
            ExtendedDatabase db = new ExtendedDatabase();

            //Act && Assert
            Assert.Throws<InvalidOperationException>(() => db.Remove());
        }

        [Test]
        public void ThrowsIOEIfUsernameDoesNotExist()
        {
            //Arrange
            ExtendedDatabase db = new ExtendedDatabase
            (new Person[]
            {
                new Person(34, "V"),
                new Person(90, "M"),
                new Person(998, "J")
            });

            //Act && Assert
            Assert.Throws<InvalidOperationException>(() => db.FindByUsername("K"));
        }

        [Test]
        public void ThrowsANEWhenUsernameIsNullOrEmpty()
        {
            //Arrange
            ExtendedDatabase db = new ExtendedDatabase
            (new Person[]
            {
                new Person(34, "V"),
                new Person(90, "M")
            });

            //Act && Assert
            Assert.Throws<ArgumentNullException>(() => db.FindByUsername(null));
            Assert.Throws<ArgumentNullException>(() => db.FindByUsername(string.Empty));
        }

        [Test]
        public void UsernamesAreCaseSensitive()
        {
            //Arrange
            ExtendedDatabase db = new ExtendedDatabase
            (new Person[]
            {
                new Person(34, "Volq"),
                new Person(90, "Molq")
            });

            //Act && Assert
            Assert.Throws<InvalidOperationException>(() => db.FindByUsername("molq"));
        }

        [Test]
        public void ThrowsIOEWhenIdsDoNotMatch()
        {
            //Arrange
            ExtendedDatabase db = new ExtendedDatabase
            (new Person[]
            {
                new Person(34, "Volq"),
                new Person(90, "Molq")
            });

            //Act && Assert
            Assert.Throws<InvalidOperationException>(() => db.FindById(33));
        }

        [Test]
        public void ThrowsAOOREWhenIdsAreNegative()
        {
            //Arrange
            ExtendedDatabase db = new ExtendedDatabase
            (new Person[]
            {
                new Person(34433, "Volq"),
                new Person(90, "Molq")
            });

            //Act && Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => db.FindById(-90));
            Assert.Throws<ArgumentOutOfRangeException>(() => db.FindById(-34433));
        }

        [Test]
        public void FindingAPersonById()
        {
            //Arrange
            ExtendedDatabase db = new ExtendedDatabase
            (new Person[]
            {
                new Person(34433, "Mammoth"),
                new Person(90, "SaberTooth"),
                new Person(567362, "Octopus"),
                new Person(2, "Behemoth")
            });

            //Act
            long id = 2;
            string expectedUserName = "Behemoth";
            Person person = db.FindById(id);
            string actualUserName = person.UserName;

            //Assert
            Assert.AreEqual(expectedUserName, actualUserName);
        }

        [Test]
        public void FindingAPersonByUserName()
        {
            //Arrange
            ExtendedDatabase db = new ExtendedDatabase
            (new Person[]
            {
                new Person(34433, "Mammoth"),
                new Person(90, "SaberTooth"),
                new Person(567362, "Octopus"),
                new Person(2, "Behemoth")
            });

            //Act
            string userName = "SaberTooth";
            long expectedId = 90;
            Person person = db.FindByUsername(userName);
            long actualId = person.Id;

            //Assert
            Assert.AreEqual(expectedId, actualId);
        }
    }
}