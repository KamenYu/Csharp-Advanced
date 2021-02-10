using System;
using System.Collections.Generic;

namespace GameDemo
{
    public class FootBallGame : Game
    {
        private List<Player> team1;
        private List<Player> team2;

        public FootBallGame()
        {
            team1 = new List<Player>(15);
            team2 = new List<Player>(15);
        }

        public override string GetDescprition()
        {
            return "0 : 0";
        }

        public override void Start()
        {
            base.Start();
            Console.WriteLine("Play Anthem");
        }

        public override void Stop()
        {
            base.Stop();
            Console.WriteLine("Speak stupidly in front of a journalist");
        }
    }
}
