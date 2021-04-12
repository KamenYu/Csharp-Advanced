using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace BankSafe.Tests
{
    public class BankVaultTests
    {
        private BankVault bv;
        private Item item;
        private Item item2;
        private Dictionary<string, Item> cells;
        [SetUp]
        public void Setup()
        {
            bv = new BankVault();
            item = new Item("Kamen", "09IIMUSAKA");
            item2 = new Item("Misho", "Shamara");
            cells = new Dictionary<string, Item>()
            {
                    {"A1", null},
                    {"A2", null},
                    {"A3", null},
                    {"A4", null},
                    {"B1", null},
                    {"B2", null},
                    {"B3", null},
                    {"B4", null},
                    {"C1", null},
                    {"C2", null},
                    {"C3", null},
                    {"C4", null}
            };
        }

        [Test]
        public void AddItemTestingCellNOTExistThrowsAE()
        {
            Assert.Throws<ArgumentException>(() => bv.AddItem("H8", item));
        }

        [Test]
        public void IfCellIsTakenThrowsAE()
        {
            bv.AddItem("A2", item);
            
            Assert.Throws<ArgumentException>(() => bv.AddItem("A2", item));
        }

        [Test]
        public void IfCellIsTakenCheckItemIDIfSameThrowsIOE()
        {
            bv.AddItem("A2", item);
            Assert.Throws<InvalidOperationException>(() => bv.AddItem("A1", item));
        }

        [Test]
        public void AddAddsItemToCell()
        {
            bv.AddItem("A2", item);
            bv.AddItem("A3", new Item("KOko", "90II"));
            Assert.AreEqual(item, bv.VaultCells["A2"]);
        }

        [Test]
        public void RemoveThrowsAEIfCellDoesNOtExist()
        {
            bv.AddItem("A2", item);
            bv.AddItem("A3", new Item("KOko", "90II"));
            Assert.Throws<ArgumentException>(() => bv.RemoveItem("K9", item));
        }

        [Test]
        public void RemoveThrowsAEIfItemIsDifferent()
        {
            bv.AddItem("A2", item);
            bv.AddItem("A3", new Item("KOko", "90II"));
            Assert.Throws<ArgumentException>(() => bv.RemoveItem("A2", item2));
        }

        [Test]
        public void IfRemoveSuccessfulItemIsNull()
        {
            bv.AddItem("A2", item);
            bv.AddItem("A3", new Item("KOko", "90II"));
            bv.RemoveItem("A2", item);
            Assert.IsNull(bv.VaultCells["A2"]);
        }

    }
}