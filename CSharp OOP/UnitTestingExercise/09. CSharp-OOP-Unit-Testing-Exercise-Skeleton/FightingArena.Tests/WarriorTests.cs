using FightingArena;
using NUnit.Framework;
using System;

namespace Tests
{
    public class WarriorTests
    {
        //REMEMBER TO REMOVE --using FightingArena;
        //AE => Argument Exception
        //IOE => Invalid Operation Exception

        private Warrior warrior;

        [SetUp]
        public void Setup()
        {
            warrior = new Warrior("Pesho", 20, 100);
        }

        [Test]
        [TestCase("V", 300, 4000)]
        [TestCase("M", 300, 0)]
        public void ConstructorSetsAllParametersProperly(string name, int damage, int hp)
        {
            //Arrange
            Warrior warr = new Warrior(name, damage, hp);

            //Assert
            Assert.AreEqual(name, warr.Name);
            Assert.AreEqual(damage, warr.Damage);
            Assert.AreEqual(hp, warr.HP);
        }

        [Test]
        [TestCase("", 50, 50)]
        [TestCase("   ", 60, 600)]
        [TestCase(null, 50, 6700)]
        public void ThrowsAEWhenNameIsNullOrEmpty(string name, int dmg, int hp)
        {
            Assert.Throws<ArgumentException>(() => new Warrior(name, dmg, hp));
        }

        [Test]
        [TestCase("K", 0, 90)]
        [TestCase("L", -1, 999)]
        public void ThrowsAEWhenDamageIsBelowOrEqualToZero(string name, int damage, int hp)
        {
            Assert.Throws<ArgumentException>(() => new Warrior(name, damage, hp));
        }

        [Test]
        [TestCase("N", 70, -1)]
        public void ThrowsAEWhenHPIsBelowZero(string name, int dmg, int hP)
        {
            Assert.Throws<ArgumentException>(() => new Warrior(name, dmg, hP));
        }

        [Test]
        [TestCase("A", 45, 30, "D", 55, 50)]
        [TestCase("A", 35, 100, "D", 45, 10)]
        [TestCase("A", 35, 80, "D", 90, 60)]
        [TestCase("A", 10, 40, "D", 50, 40)]
        public void ThrowsIOEWhenAttackerOrDeffenderHPIsEqualOrBelowMIN_ATTACK_HP
            (string attackerName, int attackerDMG, int attackerHP,
            string defenderName, int defenderDMG, int defenderHP)
        {
            //Arrange
            Warrior attacker = new Warrior(attackerName, attackerDMG, attackerHP);
            Warrior defender = new Warrior(defenderName, defenderDMG, defenderHP);

            //Assert
            Assert.Throws<InvalidOperationException>(() => attacker.Attack(defender));
        }

        [Test]
        [TestCase("A", 10, 50, 30, "D", 20, 50, 40)]
        [TestCase("A", 20, 100, 90, "D", 10, 80, 60)]
        public void AttackerHPDecreasesByDefenderDmg(
            string attackerName,
            int attackerDMG,
            int attackerHP,
            int attackerHPLeft,

            string defenderName,
            int defenderDMG,
            int defenderHP,
            int defenderHPLeft)
        {
            //Arrange
            Warrior attacker = new Warrior(attackerName, attackerDMG, attackerHP);
            Warrior defender = new Warrior(defenderName, defenderDMG, defenderHP);

            //Act
            attacker.Attack(defender);

            //Assert
            var expectedAttackerHP = attackerHPLeft;
            var expectedDefenderHP = defenderHPLeft;

            Assert.AreEqual(expectedAttackerHP, attacker.HP);
            Assert.AreEqual(expectedDefenderHP, defender.HP);
        }

        [Test]
        [TestCase(500, 100, 0)]
        [TestCase(100, 100, 0)]
        public void WhenAttackerDamageIsMoreThanDefenderHpDefenderHpBecomesZero(
            int attackerDmg, int defenderHP, int result)
        {
            //Arrange
            Warrior attacker = new Warrior("A", attackerDmg, 600);
            Warrior defender = new Warrior("D", 40, defenderHP);

            //Act
            attacker.Attack(defender);
            int actualDefenderHP = defender.HP;

            //Assert
            Assert.AreEqual(result, actualDefenderHP);
        }

        [Test]
        [TestCase(100, 500, 560, 400)]
        public void WhenDefenderHPIsMoreThanAttackerDamageDefenderHpDecreasesByAttackerDamage(
            int attackerDMG, int defenderHP, int actualAttackerHP,int actualDefenderHP )
        {
            //Arrange
            Warrior attacker = new Warrior("A", attackerDMG, 600);
            Warrior defender = new Warrior("D", 40, defenderHP);

            //Act
            attacker.Attack(defender);

            //Assert
            Assert.AreEqual(actualAttackerHP, attacker.HP);
            Assert.AreEqual(actualDefenderHP, defender.HP);
        }


        [Test] // this is TEST 8
        public void CheckAttackWithLessThanMinimumPoints()
        {
            warrior = new Warrior("Pesho", 10, 30);
            Warrior attackedWarrior = new Warrior("Gosho", 20, 50);

            Assert.Throws<InvalidOperationException>(() => warrior.Attack(attackedWarrior));
        }
    }
}
