using P03._ShoppingCart;
using P03._ShoppingCart_Before.Contracts;

namespace P03._ShoppingCart_Before.Rules
{
    public class EachAmount : IAmountRules
    {
        public decimal Calculate(OrderItem item)
        {
            return item.Quantity * 5m;
        }

        public bool IsMatch(OrderItem item)
        {
            return item.Sku.StartsWith("EACH");
        }
    }
}
