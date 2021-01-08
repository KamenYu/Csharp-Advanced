using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();
            string info;

            while ((info = Console.ReadLine()) != "Revision")
            {
                string shopName = info.Split(", ")[0];
                string good = info.Split(", ")[1];
                double price = double.Parse(info.Split(", ")[2]);

                if (shops.ContainsKey(shopName) == false)
                {
                    shops.Add(shopName, new Dictionary<string, double>());
                    shops[shopName].Add(good, price);
                }
                else
                {
                    shops[shopName].Add(good, price);
                }
            }

            foreach (var shop in shops.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
