using System;
using System.Collections.Generic;
using System.Linq;
using PlayersAndMonsters.Models.Players.Contracts;
using PlayersAndMonsters.Repositories.Contracts;

namespace PlayersAndMonsters.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private Dictionary<string, IPlayer> players;

        public PlayerRepository()
        {
            players = new Dictionary<string, IPlayer>();
        }

        public int Count => players.Count;

        public IReadOnlyCollection<IPlayer> Players
            => players.Values.ToList().AsReadOnly();

        public void Add(IPlayer player)
        {
            NUllPlayer(player);

            if (players.ContainsKey(player.Username))
            {
                throw new ArgumentException($"Player {player.Username} already exists!");
            }

            players.Add(player.Username, player);
        }       

        public IPlayer Find(string username)
            => players.Values.FirstOrDefault(v => v.Username == username);

        public bool Remove(IPlayer player)
        {
            NUllPlayer(player);
            return players.Remove(player.Username);
        }

        private static void NUllPlayer(IPlayer player)
        {
            if (player == null)
            {
                throw new ArgumentException("Player cannot be null");
            }
        }
    }
}
