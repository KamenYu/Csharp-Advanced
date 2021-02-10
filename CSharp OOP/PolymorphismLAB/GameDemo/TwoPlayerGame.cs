namespace GameDemo
{
    public abstract class TwoPlayerGame : Game
    {
        protected Player player1; // encapsulation
        protected Player player2;

        public TwoPlayerGame(Player pl1, Player pl2)
        {
            player1 = pl1;
            player2 = pl2;
        }

        public override string GetDescprition()
        {
            return $"A romantic game for two...";
        }
    }
}
