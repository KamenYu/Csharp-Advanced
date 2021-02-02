using System;
using System.Collections.Generic;
using System.Linq;

using ShoppingSpree.Common;


namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] peopleInfo = Console.ReadLine()
                .Split(new[] { ';' });

            string[] productInfo = Console.ReadLine()
                .Split(new[] { ';', '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);           

            try
            {
                List<Person> people = new List<Person>();

                for (int i = 0; i < peopleInfo.Length; i++)
                {
                    string[] splitted = peopleInfo[i].Split("=");
                    Person currentP = new Person(splitted[0], decimal.Parse(splitted[1]));
                    people.Add(currentP);
                }

                List<Product> products = new List<Product>();
                for (int i = 0; i < productInfo.Length; i += 2)
                {
                    products.Add(new Product(productInfo[i], decimal.Parse(productInfo[i + 1])));
                }

                string command = Console.ReadLine();

                while (command != "END")
                {
                    string[] purchaseInfo = command
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    if (people.Any(per => per.Name == purchaseInfo[0]))
                    {
                        Person per = people.Where(per => per.Name == purchaseInfo[0]).FirstOrDefault();
                        Product pro = products.Where(pro => pro.Name == purchaseInfo[1]).FirstOrDefault();
                        per.Purchase(pro);
                    }

                    command = Console.ReadLine();
                }

                foreach (var person in people)
                {
                    Console.WriteLine(person);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}
