namespace P03._ShoppingCart
{
    using System.Collections.Generic;
    using System.Linq;
    using P03._ShoppingCart_Before.Contracts;
    using P03._ShoppingCart_Before.Rules;

    public class Cart
    {
        private readonly List<OrderItem> items;

        public Cart()
        {
            this.items = new List<OrderItem>();
        }

        public IEnumerable<OrderItem> Items
        {
            get { return new List<OrderItem>(this.items); }
        }

        public string CustmerEmail { get; set; }

        public void Add(OrderItem orderItem)
        {
            this.items.Add(orderItem);
        }

        public decimal TotalAmount()
        {
            decimal total = 0m;
            List<IAmountRules> rules = new List<IAmountRules>()
            {
                new EachAmount(),
                new WeightAmountRule(),
                new SpecialAmountRule() // just add new rules
            };

            foreach (var item in this.items)
            {
                total += rules.First(r => r.IsMatch(item)).Calculate(item);
            }
            
            return total; 
        }
    }
}
