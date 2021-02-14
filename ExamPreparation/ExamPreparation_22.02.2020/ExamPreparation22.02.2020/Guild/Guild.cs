using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> roster;

        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            roster = new List<Player>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return roster.Count; } }

        public void AddPlayer(Player player)
        {
            if (roster.Count < Capacity)
            {
                roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            Player player = roster.FirstOrDefault(n => n.Name == name);
            roster.Remove(player);
            if (player == null)
            {
                return false;
            }

            return true;
        }

        public void PromotePlayer(string name)
        {
            Player player = roster.FirstOrDefault(n => n.Name == name);

            if (player != null && player.Rank != "Member")
            {
                player.Rank = "Member";
            }            
        }

        public void DemotePlayer(string name)
        {
            Player player = roster.FirstOrDefault(n => n.Name == name);

            if (player != null && player.Rank != "Trial")
            {
                player.Rank = "Trial";
            }            
        }

        public Player[] KickPlayersByClass(string @class)
        {
            Player[] playersToKickOut = roster.Where(p => p.Class == @class).ToArray(); // really?

            foreach (var pl in playersToKickOut)
            {
                roster.Remove(pl);
            }

            return playersToKickOut;
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Players in the guild: {Name}");

            foreach (Player pl in roster)
            {
                result.AppendLine(pl.ToString());
            }

            return result.ToString().Trim();
        }
    }
}
