using System;
using Easter.Models.Eggs.Contracts;

namespace Easter.Models.Eggs
{
    public class Egg : IEgg
    {
        private string name;
        private int energyRequired;

        public Egg(string name, int energyRequired)
        {
            Name = name;
            EnergyRequired = energyRequired;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Egg name cannot be null or empty.");
                }
                name = value;
            }
        }

        public int EnergyRequired
        {
            get => energyRequired;
            protected set
            {
                if (value <= 0)
                {
                    value = 0;
                }

                energyRequired = value;
            }
        }

        public void GetColored()
        {
            energyRequired -= 10;
        }

        public bool IsDone()
            => energyRequired == 0 ? true : false;
    }
}
