using System;

using ShoppingSpree.Common;
namespace ShoppingSpree
{
    public class Product
    {
        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name {
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

        public decimal Cost
        {
            get { return cost; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(GlobalConstants.MoneyErrorMsg);
                }

                cost = value;
            } 
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
