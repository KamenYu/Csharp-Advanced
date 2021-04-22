using PlayersAndMonsters.Models.Players.Contracts;
using PlayersAndMonsters.Repositories.Contracts;

namespace PlayersAndMonsters.Models.Players.Models
{
    public class Advanced : Player, IPlayer
    {
        public Advanced(ICardRepository cardRepo, string name)
            : base(cardRepo, name, 250)
        {
        }
    }
}
