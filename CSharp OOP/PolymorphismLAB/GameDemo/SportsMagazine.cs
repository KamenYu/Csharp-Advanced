using System;
using System.Collections.Generic;

namespace GameDemo
{
    public class SportsMagazine
    {
        private ICollection<Game> games;

        public SportsMagazine()
        {
            games = new List<Game>();
        }

        public void AddGame(Game game)
        {
            games.Add(game);
        }

        public void StartGames()
        {
            foreach (var g in games)
            {
                g.Start();
            }
        }

        public void StoptGames()
        {
            foreach (var g in games)
            {
                g.Stop();
            }
        }

        public void PrintDescriptions()
        {
            foreach (var g in games)
            {
                Console.WriteLine(g.GetDescprition());
            }
        }
    }
}
