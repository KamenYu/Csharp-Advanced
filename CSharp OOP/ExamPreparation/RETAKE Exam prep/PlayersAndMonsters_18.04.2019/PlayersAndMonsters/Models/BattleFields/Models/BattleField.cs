using System;
using System.Linq;
using PlayersAndMonsters.Models.BattleFields.Contracts;
using PlayersAndMonsters.Models.Players.Contracts;

namespace PlayersAndMonsters.Models.BattleFields.Models
{
    public class BattleField : IBattleField
    {
        public void Fight(IPlayer attackPlayer, IPlayer enemyPlayer)
        {
            if (attackPlayer.IsDead || enemyPlayer.IsDead)
            {
                throw new ArgumentException("Player is dead!");
            }

            PlayerModification(attackPlayer);
            PlayerModification(enemyPlayer);

            attackPlayer =  BoostPlayer(attackPlayer);
            enemyPlayer = BoostPlayer(enemyPlayer);

            while (attackPlayer.IsDead == false  && enemyPlayer.IsDead == false)
            {
                int attackPlayerDmg = attackPlayer.CardRepository.Cards.Select(c => c.DamagePoints).Sum();
                enemyPlayer.TakeDamage(attackPlayerDmg);

                if (enemyPlayer.IsDead)
                {
                    break;
                }

                int enemyPlayerDmg = enemyPlayer.CardRepository.Cards.Select(c => c.DamagePoints).Sum();
                attackPlayer.TakeDamage(enemyPlayerDmg);
            }

        }

        private static IPlayer BoostPlayer(IPlayer player)
        {
            player.Health += player.CardRepository
                            .Cards
                            .Select(c => c.HealthPoints)
                            .Sum();

            return player;
        }

        private static void PlayerModification(IPlayer player)
        {
            if (player.GetType().Name == "Beginner")
            {
                player.Health += 40;

                foreach (var card in player.CardRepository.Cards)
                {
                    card.DamagePoints += 30;
                }
            }
        }
    }
}
