using P03._ShoppingCart;
using P03._ShoppingCart_Before.Contracts;

namespace P03._ShoppingCart_Before.Rules
{
    public class WeightAmountRule : IAmountRules
    {
        public decimal Calculate(OrderItem item)
        {
            return item.Quantity * 4m / 1000;
        }

        public bool IsMatch(OrderItem item)
        {
            return item.Sku.StartsWith("WEIGHT");
        }
    }
}
