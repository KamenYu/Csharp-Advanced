using System;

using FTG.Common;
namespace FTG.Models
{
    public class Stats
    {
        private const int MinStat = 0;
        private const int MaxStat = 100;
        private const double StatsCount = 5;

        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Stats(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        public int Endurance { get { return endurance; }
            set
            {
                ValidateStat(nameof(Endurance), value);

                endurance = value;
            }
        }

        public int Sprint
        {
            get { return sprint; }
            set
            {
                ValidateStat(nameof(Sprint), value);

                sprint = value;
            }
        }

        public int Dribble
        {
            get { return dribble; }
            set
            {
                ValidateStat(nameof(Dribble), value);

                dribble = value;
            }
        }

        public int Passing
        {
            get { return passing; }
            set
            {
                ValidateStat(nameof(Passing), value);

                passing = value;
            }
        }

        public int Shooting
        {
            get { return shooting; }
            set
            {
                ValidateStat(nameof(Shooting), value);

                shooting = value;
            }
        }

        public double AverageStats =>
            (Endurance + Passing + Dribble + Shooting + Sprint) / StatsCount;

        public void ValidateStat(string name, int value)
        {
            if (value < MinStat || value > MaxStat)
            {
                throw new ArgumentException(string
                    .Format(GlobalConstants.StatError, name, MinStat, MaxStat));
            }
        }
    }
}
