using System;
using System.Collections.Generic;

using ShoppingSpree.Common;
namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> products = new List<Product>();

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.NameErrorMsg);
                }

                name = value;
            }
        }

        public decimal Money
        {
            get { return money; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(GlobalConstants.MoneyErrorMsg);
                }

                money = value;
            }
        }

        public void Purchase(Product pro) // maybe fixed
        {
            if (Money - pro.Cost >= 0)
            {
                Money -= pro.Cost;
                products.Add(pro);
                Console.WriteLine($"{Name} bought {pro.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} can't afford {pro.Name}");
            }
        }

        public override string ToString()
        {
            if (products.Count == 0)
            {
                return $"{Name} - Nothing bought";
            }
            else
            {
               return $"{Name} - {string.Join(", ", products)}";
            }
        }
    }
}
