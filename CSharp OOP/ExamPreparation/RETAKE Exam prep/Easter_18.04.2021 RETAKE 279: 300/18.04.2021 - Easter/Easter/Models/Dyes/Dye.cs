using System;
using Easter.Models.Dyes.Contracts;

namespace Easter.Models.Dyes
{
    public class Dye : IDye
    {
        private int power;

        public Dye(int power)
        {
            Power = power;
        }

        public int Power
        {
            get => power;
            protected set
            {
                if (value <= 0)
                {
                    value = 0;
                }

                power = value;
            }
        }

        public bool IsFinished()
            => power >= 0 ? true : false;

        public void Use()
        {
            power -= 10;
        }
    }
}
