using System;
using System.Collections.Generic;
using ViceCity.Models.Neghbourhoods.Contracts;
using ViceCity.Models.Players.Contracts;

namespace ViceCity.Models.Neghbourhoods.Models
{
    public class Neighbourhood : INeighbourhood
    {
        public void Action(IPlayer mainPlayer, ICollection<IPlayer> civilPlayers)
        {
            //main character aims all civils
            // takes a gun
            // shot bullets == life taken
            // if currents gun total bullets == 0, takes another gun
            // shoots at people until all people are dead OR all guns have no bullets

            foreach (var gun in mainPlayer.GunRepository.Models)
            {
                foreach (var cp in civilPlayers)
                {
                    while (cp.IsAlive && gun.CanFire)
                    {
                        cp.TakeLifePoints(gun.Fire());
                    }

                    if (gun.CanFire == false)
                    {
                        break;
                    }
                }
            }

            //only alive ones shoot main
            // takes a gun and shoots the same way like main
            // one by one shoot
            // action ends when main is dead

            foreach (var cp in civilPlayers)
            {
                if (cp.IsAlive == false)
                {
                    continue;
                }

                foreach (var gun in cp.GunRepository.Models)
                {
                    while (mainPlayer.IsAlive && gun.CanFire)
                    {
                        mainPlayer.TakeLifePoints(gun.Fire());
                    }

                    if (mainPlayer.IsAlive == false)
                    {
                        break;
                    }
                }

                if (mainPlayer.IsAlive == false)
                {
                    break;
                }
            }


           
        }
    }
}
