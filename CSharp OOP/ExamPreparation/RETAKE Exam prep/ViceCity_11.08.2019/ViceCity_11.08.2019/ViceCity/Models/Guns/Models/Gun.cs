using System;
using ViceCity.Models.Guns.Contracts;

namespace ViceCity.Models.Guns.Models
{
    public abstract class Gun : IGun
    {
        private string name;
        private int bulletsPerBarrel;
        private int totalBullets;

        protected Gun(string name, int bulletsPerBarrel, int totalBullets)
        {
            Name = name;
            BulletsPerBarrel = bulletsPerBarrel;
            TotalBullets = totalBullets;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or a whitespace!");
                }

                name = value;
            }
        }

        public int BulletsPerBarrel
        {
            get { return bulletsPerBarrel; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Bullets cannot be below zero!");
                }

                bulletsPerBarrel = value;
            }
        }

        public int TotalBullets
        {
            get { return totalBullets; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Total bullets cannot be below zero!");
                }

                totalBullets = value;
            }
        }

        public bool CanFire => TotalBullets > 0 || BulletsPerBarrel > 0;

        public abstract int Fire();

        protected void Reload(int barrelCapacity)
        {
            if (TotalBullets >= barrelCapacity)
            {
                BulletsPerBarrel = barrelCapacity;
                TotalBullets -= barrelCapacity;
            }          
        }

        protected int DecreaseBullets(int bullets)
        {
            int res = 0;
            if (BulletsPerBarrel - bullets >= 0 )
            {
                BulletsPerBarrel -= bullets;
                res = bullets;
            }

            return res;
        }
    }
}
