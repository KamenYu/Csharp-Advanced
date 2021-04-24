using System;
namespace CompositePattern3
{
    public class SingleGift : GiftBase // like the Leaf
    {
        public SingleGift(string name, int price)
            : base(name, price)
        {
        }

        public override int CalculateTotalPrice()
        {
            Console.WriteLine($"{name} with price {price}");

            return price;
        }
    }
}
