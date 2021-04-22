using FightingArena;// for Judge -> REMOVE!!!
using NUnit.Framework;
using System;
using System.Linq;

namespace Tests
{
    public class ArenaTests
    {
        private Arena arena;

        [SetUp]
        public void Setup()
        {
            //Arrange
            arena = new Arena();
        }

        [Test]
        public void ConstructorSetsACollectionThatIsNotNull()
        {
            //Act && Assert
            Assert.IsNotNull(arena.Warriors);
        }

        [Test]
        public void ConstructorSetsArenaThatIsNotNull()
        {
            //Act && Assert
            Assert.IsNotNull(arena);
        }

        [Test]
        public void EnrollThrowsIOEWhenInvalidWarriorIsAdded()
        {
            //Arrange
            Warrior warrior = new Warrior("A", 34, 78);

            //Act && Assert
            arena.Enroll(warrior);

            //Assert
            Assert.Throws<InvalidOperationException>(() => arena.Enroll(warrior));
        }

        [Test]
        public void EnrollingSameWarriorThrowsIOE()
        {
            Warrior warrior = new Warrior("A", 34, 78);
            arena.Enroll(warrior);

            Assert.Throws<InvalidOperationException>(() => arena.Enroll(warrior));
        }

        [Test]
        [TestCase("A", 34, 78)]
        public void EnrollShouldAddWarriorToCollection(
            string attackerName,
            int attackerDmg,
                int attackerHp)
        {
            //Arrange
            Warrior warrior = new Warrior(attackerName, attackerDmg, attackerHp);

            //Act && Assert
            arena.Enroll(warrior);
            int expectedCount = 1;
            bool isAnyAttacker = arena.Warriors.Any(n => n.Name == attackerName);

            //Assert
            Assert.AreEqual(expectedCount, arena.Count);
            Assert.IsTrue(isAnyAttacker);
        }

        [Test]
        [TestCase("A", "D")]
        public void AttackingShouldThrowIOEWhenWarriorsDoNotExist(string attacker, string defender)
        {
            //Arrange
            Warrior warrior = new Warrior(attacker, 90, 800);

            Assert.Throws<InvalidOperationException>(() => arena.Fight(attacker, defender));
            //Act
            arena.Enroll(warrior);

            //Assert
            Assert.Throws<InvalidOperationException>(() => arena.Fight(attacker, defender));
        }

        [Test]
        public void FightShouldWorkAsExpected()
        {
            //Arrange
            Warrior attacker = new Warrior("Golem", 60, 500);
            Warrior defender = new Warrior("Micro", 35, 1000);

            //Act
            arena.Enroll(attacker);
            arena.Enroll(defender);
            arena.Fight("Golem", "Micro");

            int attackerHP = arena.Warriors.FirstOrDefault(n => n.Name == "Golem").HP;
            int defenderHP = arena.Warriors.FirstOrDefault(n => n.Name == "Micro").HP;

            //Assert
            Assert.AreEqual(465, attackerHP);
            Assert.AreEqual(940, defenderHP);
        }
    }  
}
