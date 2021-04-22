using System;
namespace ViceCity.Models.Guns.Models
{
    public class Rifle : Gun
    {
        public Rifle(string name) : base(name, 50, 500)
        { }

        public override int Fire()
        {
            if (BulletsPerBarrel < 5)
            {
                Reload(50);
            }

            int result = DecreaseBullets(5);
            return result;
        }
    }
}
