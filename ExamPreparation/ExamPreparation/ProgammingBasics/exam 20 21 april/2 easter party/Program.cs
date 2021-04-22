using System;
namespace _2_easter_party
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Ако покани:
            //•	Между 10(вкл.) и 15(вкл.) човека-> 15 % отстъпка от куверта за един човек
            //•	Между 15 и 20(вкл.) човека-> 20 % отстъпка от куверта за един човек
            //•	Над 20 човека-> 25 % отстъпка от куверта за един човек
            //Деси трябва да предвиди и закупуването на торта за партито.Цената на тортата е 10 % от бюджета на Деси.


            int guests = int.Parse(Console.ReadLine());
            double pricePerGuest = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double cakePrice = budget * 0.1;
            double guestDiscount = 0;

            if (guests >= 10 && guests <= 15)
            {
                guestDiscount = pricePerGuest - pricePerGuest * 0.15;
            }
            else if (guests > 15 && guests <= 20)
            {
                guestDiscount =pricePerGuest - pricePerGuest * 0.2;
            }
            else if (guests > 20)
            {
                guestDiscount = pricePerGuest - pricePerGuest * 0.25;
            }
            else
            {
                guestDiscount = pricePerGuest;
            }
            double discountedPrice = (guests * guestDiscount) + cakePrice;
            double restMoney = Math.Abs(budget - discountedPrice);

            if (budget >= discountedPrice)
            {
                Console.WriteLine($"It is party time! {restMoney:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {restMoney:f2} leva needed.");
            }
        }
    }
}
