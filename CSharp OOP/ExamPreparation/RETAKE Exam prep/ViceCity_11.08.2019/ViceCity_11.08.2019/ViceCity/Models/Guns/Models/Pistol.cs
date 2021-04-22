using System;
namespace ViceCity.Models.Guns.Models
{
    public class Pistol : Gun
    {
        public const int BulletsPerFire = 1;
        public const int InitialTotalBulets = 100;
        public const int InitialBarrelBulets = 10;
        public Pistol(string name)
            : base(name, InitialBarrelBulets, InitialTotalBulets)
        { }

        public override int Fire()
        {
            if (BulletsPerBarrel < BulletsPerFire)
            {
                Reload(InitialBarrelBulets);
            }

            int result = DecreaseBullets(BulletsPerFire);
            return result;
        }
    }
}
