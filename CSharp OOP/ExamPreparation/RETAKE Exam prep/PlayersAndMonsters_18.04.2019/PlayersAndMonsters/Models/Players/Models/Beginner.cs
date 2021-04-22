using PlayersAndMonsters.Models.Players.Contracts;
using PlayersAndMonsters.Repositories.Contracts;

namespace PlayersAndMonsters.Models.Players.Models
{
    public class Beginner : Player, IPlayer
    {
        public Beginner(ICardRepository cardRepo, string name)
            : base(cardRepo, name, 50)
        { }
    }
}
