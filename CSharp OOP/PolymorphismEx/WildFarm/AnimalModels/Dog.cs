using System;
using System.Collections.Generic;

using WildFarm.Base;
using WildFarm.FoodModels;

namespace WildFarm.AnimalModels
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        { }

        public override double WeightMultiplier => 0.4;

        public override ICollection<Type> PreferredFoods => new List<Type>() { typeof(Meat) };

        public override string ProduceSoundSForFood()
        {
            return "Woof!";
        }
    }
}
