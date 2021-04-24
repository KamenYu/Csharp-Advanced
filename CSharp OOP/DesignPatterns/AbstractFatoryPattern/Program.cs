using System;
using AbstractFatoryPattern.Factories;

namespace AbstractFatoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string techType = Console.ReadLine();

            ITechnologyAbstractFactory abstractFactory = null;

            if (techType.ToLower() == "samsung")
            {
                abstractFactory = new SamsungFactory();
            }
            else if (techType.ToLower() == "apple")
            {
                abstractFactory = new AppleFactory();
            }

            IMobilePhone mobilePhone = abstractFactory.CreatePhone();
            ITablet tablet = abstractFactory.CreateTablet();

            Console.WriteLine(mobilePhone.GetType().Name);
            Console.WriteLine(tablet.GetType().Name);
        }
    }
}
