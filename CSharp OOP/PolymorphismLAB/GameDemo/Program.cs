using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SportsMagazine magazine = new SportsMagazine();
            magazine.AddGame(new ChessGame
                (new Player("Topalow"),
                 new Player("Other")));
            magazine.AddGame(new FootBallGame());
            magazine.AddGame(new Tennis
                (new Player("Pironkova"), new Player("Djnebjokova")));

            magazine.StartGames();
            magazine.StoptGames();
            magazine.PrintDescriptions();
        }
    }
}
