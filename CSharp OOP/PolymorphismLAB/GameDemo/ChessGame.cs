namespace GameDemo
{
    public class ChessGame : TwoPlayerGame
    {
        //private bool isWhitePlaying;

        public ChessGame(Player playerOne, Player playerTwo)
            : base(playerOne, playerTwo)
        { }

        public override string GetDescprition()
        {
            return "Thinking so much";
        }

        public override void Start()
        {
            base.Start();
        }

        public override void Stop()
        {
            base.Stop();
        }

        //public Player GetMovingPlayer()
        //{
        //    if (isWhitePlaying)
        //    {
        //        return playerOne;
        //    }
        //    else
        //    {
        //        return playerTwo;
        //    }
        //}
    }
}
