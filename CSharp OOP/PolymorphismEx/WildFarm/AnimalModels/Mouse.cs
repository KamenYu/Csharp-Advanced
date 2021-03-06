﻿using System;
using System.Collections.Generic;

using WildFarm.Base;
using WildFarm.FoodModels;

namespace WildFarm.AnimalModels
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override double WeightMultiplier => 0.1;

        public override ICollection<Type> PreferredFoods => new List<Type>() { typeof(Vegetable), typeof(Fruit) };

        public override string ProduceSoundSForFood()
        {
            return "Squeak";           
        }
    }
}
