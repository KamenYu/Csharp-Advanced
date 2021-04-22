using System;
using PlayersAndMonsters.Models.Cards.Contracts;

namespace PlayersAndMonsters.Models.Cards.Models
{
    public class MagicCard : Card, ICard
    {
        public MagicCard(string name)
            : base(name, 5, 80)
        {
        }
    }
}
