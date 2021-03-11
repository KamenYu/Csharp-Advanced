using System;
using P03._ShoppingCart;

namespace P03._ShoppingCart_Before.Contracts
{
    public interface IAmountRules
    {
        decimal Calculate(OrderItem item);

        bool IsMatch(OrderItem item);
    }
}
