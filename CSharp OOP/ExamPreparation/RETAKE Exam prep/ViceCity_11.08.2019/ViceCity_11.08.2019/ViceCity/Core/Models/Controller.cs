using System;
using System.Collections.Generic;
using System.Linq;
using ViceCity.Core.Contracts;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Guns.Models;
using ViceCity.Models.Players.Contracts;
using ViceCity.Models.Players.Models;
using ViceCity.Models.Neghbourhoods.Contracts;
using ViceCity.Models.Neghbourhoods.Models;
using System.Text;

namespace ViceCity.Core.Models
{
    public class Controller : IController
    {
        private readonly IPlayer main;
        private readonly List<IPlayer> civils;
        private readonly List<IGun> guns;
        private readonly INeighbourhood neighourhood;
        public Controller()
        {
            main = new MainPlayer();
            civils = new List<IPlayer>();
            guns = new List<IGun>();
            neighourhood = new Neighbourhood();
        }

        public string AddGun(string type, string name)
        {
            IGun gun = null;

            if (type == "Pistol")
            {
                gun = new Pistol(name);
            }
            else if (type == "Rifle")
            {
                gun = new Rifle(name);
            }
            else
            {
                return "Invalid gun type!";
            }

            guns.Add(gun);
            return $"Successfully added {name} of type: {type}";
        }

        public string AddGunToPlayer(string name) // players name
        {
            if (guns.Count == 0)
            {
                return "There are no guns in the queue!";
            }

            IGun gun = guns.First();
            string message = string.Empty;
            if (name == "Vercetti")
            {               
                main.GunRepository.Add(gun);

                message = $"Successfully added {gun.Name} to the Main Player: Tommy Vercetti";
            }
            else if (civils.FirstOrDefault(x => x.Name == name) == null)
            {
                message = "Civil player with that name doesn't exist!";
            }
            else
            {               
                civils.FirstOrDefault(x => x.Name == name).GunRepository.Add(gun);
                message =  $"Successfully added {gun.Name} to the Civil Player: {name}";
            }

            guns.Remove(gun);
            return message;
        }

        public string AddPlayer(string name)
        {
            IPlayer player = new CivilPlayer(name);
            civils.Add(player);
            return $"Successfully added civil player: {name}";
        }

        public string Fight()
        {
            StringBuilder result = new StringBuilder();
            int mainPlayerLP = main.LifePoints;
            int civilsTotalHealth = civils.Sum(x => x.LifePoints);
            int civilsBefore = civils.Count;

            neighourhood.Action(main, civils);
            int mainPlayerLPAfter = main.LifePoints;

            if (mainPlayerLP == mainPlayerLPAfter && civilsTotalHealth == civils.Sum(x => x.LifePoints))
            {
                return result.AppendLine("Everything is okay").ToString().TrimEnd();
            }
            else
            {
                result.AppendLine("A fight happened:");
                result.AppendLine($"Tommy live points: {main.LifePoints}!");
                result.AppendLine($"Tommy has killed: {civilsBefore - civils.Count} players!");
                result.AppendLine($"Left Civil Players: {civils.Count}!");
            }

            return result.ToString().TrimEnd();
        }
    }
}
