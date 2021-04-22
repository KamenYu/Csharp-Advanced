using System.Text;

using PlayersAndMonsters.Common;
using PlayersAndMonsters.Core.Contracts;
using PlayersAndMonsters.Core.Factories;
using PlayersAndMonsters.Core.Factories.Contracts;
using PlayersAndMonsters.Models.BattleFields.Contracts;
using PlayersAndMonsters.Models.BattleFields.Models;
using PlayersAndMonsters.Models.Cards.Contracts;
using PlayersAndMonsters.Models.Players.Contracts;
using PlayersAndMonsters.Repositories;
using PlayersAndMonsters.Repositories.Contracts;

namespace PlayersAndMonsters.Core
{
    public class ManagerController : IManagerController
    {
        private IPlayerRepository playerRepo;
        private ICardRepository cardRepo;
        private IPlayerFactory playerFactory;
        private ICardFactory cardFactory;
        private IBattleField battleField;

        public ManagerController()
        {
            playerRepo = new PlayerRepository();
            cardRepo = new CardRepository();
            playerFactory = new PlayerFactory();
            cardFactory = new CardFactory();
            battleField = new BattleField();
        }

        public string AddCard(string type, string name)
        {
            ICard card = cardFactory.CreateCard(type, name);
            cardRepo.Add(card);
            return $"Successsfully added card of type {type}Card with name: {name}";
        }

        public string AddPlayer(string type, string username)
        {
            IPlayer player = playerFactory.CreatePlayer(type, username);
            playerRepo.Add(player);
            return $"Successsfully added card: {type} to user {username}";
        }

        public string AddPlayerCard(string username, string cardName)
        {
            IPlayer pl = playerRepo.Find(username);
            ICard card = cardRepo.Find(cardName);
            //cardRepo.Remove(card); // CHECK
            pl.CardRepository.Add(card);

            return $"Successfully added card: {card.Name} to user: {pl.Username}";
        }

        public string Fight(string attackUser, string enemyUser)
        {
            IPlayer attacker = playerRepo.Find(attackUser);
            IPlayer defender = playerRepo.Find(enemyUser);
            battleField.Fight(attacker, defender);
            return $"Attack user health {attacker.Health} - Enemy user health {defender.Health}";
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();
            foreach (var pl in playerRepo.Players)
            {
                result.AppendLine(string
                    .Format(ConstantMessages.PlayerReportInfo,
                    pl.Username,
                    pl.Health,
                    pl.CardRepository.Count));

                foreach (var card in pl.CardRepository.Cards)
                {
                    result.AppendLine(
                        string.Format(
                            ConstantMessages.CardReportInfo,
                            card.Name,
                            card.DamagePoints));
                }
            }

            result.AppendLine(ConstantMessages.DefaultReportSeparator);

            return result.ToString().TrimEnd();
        }
    }
}
