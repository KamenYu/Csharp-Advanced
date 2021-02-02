using System;

using FTG.Common;
namespace FTG.Models
{
    public class Player
    {
        private string name;

        public Player(string name, Stats stats)
        {
            Name = name;
            Stats = stats;
        }


        public string Name { get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException
                        (GlobalConstants.NameError);
                }

                name = value;
            }
        }

        public Stats Stats { get; set; }

        public double OverAllSkill => Stats.AverageStats;
    }
}
