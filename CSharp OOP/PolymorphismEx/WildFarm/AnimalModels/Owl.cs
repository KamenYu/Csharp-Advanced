using System;
using System.Collections.Generic;

using WildFarm.Base;
using WildFarm.FoodModels;

namespace WildFarm.AnimalModels
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        { }

        public override double WeightMultiplier => 0.25;

        public override ICollection<Type> PreferredFoods => new List<Type>() { typeof(Meat) };

        public override string ProduceSoundSForFood()
        {
            return "Hoot Hoot";
        }
    }
}
