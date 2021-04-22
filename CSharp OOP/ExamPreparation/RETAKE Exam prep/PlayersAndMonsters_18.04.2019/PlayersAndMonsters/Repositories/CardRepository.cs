using System;
using System.Collections.Generic;
using System.Linq;
using PlayersAndMonsters.Models.Cards.Contracts;
using PlayersAndMonsters.Repositories.Contracts;

namespace PlayersAndMonsters.Repositories
{
    public class CardRepository : ICardRepository
    {
        //private Dictionary<string, ICard> cards;
        private List<ICard> cards;
        public CardRepository()
        {
            cards = new List<ICard>();
        }

        public int Count => cards.Count;

        public IReadOnlyCollection<ICard> Cards => cards.AsReadOnly();       

        public void Add(ICard card)
        {
            NUllCard(card);

            if (cards.Contains(card))
            {
                throw new ArgumentException($"Card {card.Name} already exists!");
            }

            cards.Add(card);
        }

        public ICard Find(string name)
            => cards.FirstOrDefault(v => v.Name == name);

        public bool Remove(ICard card)
        {
            NUllCard(card);
            return cards.Remove(card);
        }

        private static void NUllCard(ICard card)
        {
            if (card == null)
            {
                throw new ArgumentException("Card cannot be null");
            }
        }
    }
}
