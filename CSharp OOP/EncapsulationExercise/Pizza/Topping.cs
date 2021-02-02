using System;
using System.Collections.Generic;

using Pizza.Common;
namespace Pizza
{
    public class Topping
    {
        private const double MinWeight = 1;
        private const double MaxWeight = 50;
        private const double BaseCalories = 2;
        private readonly Dictionary<string, double> DefaultToppings =
            new Dictionary<string, double>()
            {
                { "meat", 1.2},
                { "veggies", 0.8 },
                { "cheese", 1.1 },
                { "sauce" , 0.9}
            };

        private string type;
        private double weight;

        public Topping(string type, double weight)
        {
            Type = type;
            Weight = weight;
        }

        public string Type {
            get { return type; }
            set
            {
                if (DefaultToppings.ContainsKey(value.ToLower()) == false)
                {
                    throw new ArgumentException
                        (string
                        .Format(DefaultErrorMsgs
                        .ToppingTypeErrorMsg, value));
                }

                type = value;
            }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value < MinWeight || value > MaxWeight)
                {
                    throw new ArgumentException
                        (string
                        .Format(DefaultErrorMsgs
                        .ToppingWeightErrorMsg, Type, MinWeight, MaxWeight));
                }

                weight = value;
            }
        }

        public double Calories => BaseCalories * DefaultToppings[Type.ToLower()] * Weight;
    }
}
