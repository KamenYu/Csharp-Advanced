﻿using PlayersAndMonsters.Models.Cards.Contracts;

namespace PlayersAndMonsters.Models.Cards.Models
{
    public class TrapCard : Card, ICard
    {
        public TrapCard(string name)
            : base(name,120 , 5)
        { }
    }
}
