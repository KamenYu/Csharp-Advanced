using System;
using System.Collections.Generic;

namespace CompositePattern3
{
    public class CompositeGift : GiftBase, IGiftOperation
    {
        private readonly ICollection<GiftBase> presents;
        public CompositeGift(string name, int price)
            : base(name, price)
        {
            presents = new HashSet<GiftBase>();
        }

        public void Add(GiftBase gift)
            => presents.Add(gift);

        public void Remove(GiftBase gift)
            => presents.Remove(gift);

        public override int CalculateTotalPrice()
        {
            int total = 0;

            Console.WriteLine($"{name} contains the following products with prices: ");

            foreach (var item in presents)
            {
                total += item.CalculateTotalPrice();
            }

            return total;
        }
    }
}
