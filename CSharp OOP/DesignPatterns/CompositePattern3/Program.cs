using System;

namespace CompositePattern3
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleGift phone = new SingleGift("I", 890);

            CompositeGift box = new CompositeGift("box", 0);
            box.Add(phone);
            box.Add(new SingleGift("truck", 10));
            box.Add(new SingleGift("pistol", 54));

            CompositeGift childBox = new CompositeGift("child", 0);
            childBox.Add(new SingleGift("band", 6));

            box.Add(childBox);

            Console.WriteLine(box.CalculateTotalPrice()); ;
        }
    }
}
