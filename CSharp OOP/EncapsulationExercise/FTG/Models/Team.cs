using System;
using System.Collections.Generic;
using System.Linq;

using FTG.Common;

namespace FTG.Models
{
    public class Team
    {
        private string name;
        private readonly ICollection<Player> players;

        private Team()
        {
            players = new List<Player>(); // HashSet for speed
        }

        public Team(string name) : this()
        {
            Name = name;
        }

        public string Name
        {
            get { return name; }
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

        public void Rating()
        {       
            int res = players.Count > 0 ? (int) Math.Round(players.Average(p => p.OverAllSkill)) : 0;
            Console.WriteLine($"{Name} - {res}");
        }
            

        public void AddPlayer(Player pl)
        {
            players.Add(pl);
        }

        public void RemovePlayer(string name)
        {
            Player player = players
                .FirstOrDefault(n => n.Name == name);

            if (player == null)
            {
                throw new InvalidOperationException
                    (string
                    .Format(GlobalConstants.MissingPlayer, name, Name));
            }

            players.Remove(player);
        }
    }
}
