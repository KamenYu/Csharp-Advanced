namespace GameDemo
{
    public class Tennis : TwoPlayerGame // inheritence
    {
        public Tennis(Player pl1, Player pl2)
            : base(pl1, pl2)
        { }

        public override string GetDescprition()
        {
            return $"{player1} smiles {player2} curses";
        }
    }
}
