using System;
using System.Collections.Generic;

using Pizza.Common;
namespace Pizza
{
    public class Pizza
    {
        private const int MaxNameLenght = 15;
        private const int MinNameLength = 1;
        private const int MaxToppings = 10;
        private const int MinToppings = 0;
        private string name;
        private Dough dough;
        private readonly List<Topping> toppings = new List<Topping>();

        public Pizza(string name)
        {
            Name = name;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length > MaxNameLenght)
                {
                    throw new ArgumentException
                        (string
                        .Format(DefaultErrorMsgs
                        .PizzaNameErrorMsg, MinNameLength, MaxNameLenght));
                }

                name = value;
            }
        }

        public Dough Dough
        {
            get { return dough; }
            set { dough = value; }
        }

        public int CountOfToppings => toppings.Count;

        public double TotalCalories => CalculateTotalCalories();
        
        public void AddTopping(Topping top)
        {
            if (toppings.Count > MaxToppings)
            {
                throw new ArgumentException
                    (string
                    .Format(DefaultErrorMsgs
                    .MaxToppingErrorMsg, MinToppings, MaxToppings));
            }

            toppings.Add(top);
        }

        private double CalculateTotalCalories()
        {
            double res = Dough.Calories;

            foreach (var item in toppings)
            {
                res += item.Calories;
            }

            return res; 
        }
    }
}
