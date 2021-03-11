using P03._ShoppingCart;
using P03._ShoppingCart_Before.Contracts;
namespace P03._ShoppingCart_Before.Rules
{
    public class SpecialAmountRule : IAmountRules
    {
        public decimal Calculate(OrderItem item)
        {
            var total = 0m;
            total += item.Quantity * .4m;
            int setsOfThree = item.Quantity / 3;
            total -= setsOfThree * .2m;

            return total;
        }

        public bool IsMatch(OrderItem item)
        {
            return item.Sku.StartsWith("SPECIAL");
        }
    }
}