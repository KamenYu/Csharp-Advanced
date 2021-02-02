using System;
using System.Collections.Generic;

using Pizza.Common;
namespace Pizza
{
    public class Dough
    {
        private const int MinWeight = 1;
        private const int MaxWeight = 200;
        private const int caloriesPerGram = 2;

        private readonly Dictionary<string, double> DefaultFlourType =
            new Dictionary<string, double>()
            {
                { "white", 1.5},
                { "wholegrain", 1.0}
            };

        private readonly Dictionary<string, double> DeafultBakingTechnique =
            new Dictionary<string, double>()
            {
                { "crispy", 0.9},
                { "chewy", 1.1 },
                { "homemade", 1.0 }
            };

        private string flourType; // white or wholegrain.
        private string bakingTechnique;  // crispy, chewy or homemade
        private double weigh; // grams
        //private double calories;

        public Dough(string flourType, string bakingTech, double weigh)
        {
            FlourType = flourType;
            BakingTechnique = bakingTech;
            Weigh = weigh;
        }

        public string FlourType
        {
            get { return flourType; }
            private set
            {
                if (DefaultFlourType.ContainsKey(value.ToLower()) == false)
                {
                    throw new ArgumentException
                        (DefaultErrorMsgs.DoughErrorMsg);
                }

                flourType = value;
            }
        }

        public string BakingTechnique
        {
            get { return bakingTechnique; }
            private set
            {
                if (DeafultBakingTechnique.ContainsKey(value.ToLower()) == false)
                {
                    throw new ArgumentException
                        (DefaultErrorMsgs.DoughErrorMsg);
                }

                bakingTechnique = value;
            }
        }

        public double Weigh
        {
            get { return weigh; }
            private set
            {
                if (value < MinWeight || value > MaxWeight)
                {
                    throw new ArgumentException
                        (string
                        .Format(DefaultErrorMsgs.WeighErrorMsg, MinWeight, MaxWeight));
                }

                weigh = value;
            }
        }

        public double Calories =>
            caloriesPerGram * DefaultFlourType[FlourType.ToLower()]
            * DeafultBakingTechnique[BakingTechnique.ToLower()] * Weigh;
        
    }
}
