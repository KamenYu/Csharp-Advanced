using System;
using System.Linq;
using System.Collections.Generic;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Items;
using WarCroft.Entities.Characters;
using System.Text;

namespace WarCroft.Core
{
	public class WarController
	{
		private List<Character> characters;
		private List<Item> items;

		public WarController()
        {
			characters = new List<Character>();
			items = new List<Item>();
        }


		public string JoinParty(string[] args) // characterType – string
        //name – string
		{
            if (args[0] != "Priest" && args[0] != "Warrior")
            {
				throw new ArgumentException($"Invalid character type \"{ args[0] }\"!");
            }

            if (args[0] == "Priest")
            {
				characters.Add(new Priest(args[1]));
            }

            if (args[0] == "Warrior")
            {
				characters.Add(new Warrior(args[1]));
            }

			return $"{args[1]} joined the party!";

		}

		public string AddItemToPool(string[] args) // itemname = args[0]
		{
			if (args[0] != "FirePotion" && args[0] != "HealthPotion")
			{
				throw new ArgumentException($"Invalid item \"{ args[0] }\"!");
			}

			if (args[0] == "FirePotion")
			{
				items.Add(new FirePotion());
			}

			if (args[0] == "HealthPotion")
			{
				items.Add(new HealthPotion());
			}

			return $"{args[0]} added to pool.";

		}

		public string PickUpItem(string[] args) // args[0] = characterName
		{
			Character character = characters.FirstOrDefault(n => n.Name == args[0]);

            if (character == null)
            {
				throw new ArgumentException($"Character {args[0]} not found!");
			}

            if (items.Count == 0)
            {
				throw new InvalidOperationException("No items left in pool!");
			}

			Item item = items.Last();
			character.Bag.AddItem(item);
			items.Remove(item);

			return $"{args[0]} picked up {item.GetType().Name}!";
		}

		public string UseItem(string[] args)
		{
			Character hero = characters.FirstOrDefault(n => n.Name == args[0]);

            if (hero == null)
            {
				throw new ArgumentException($"Character {args[0]} not found!");
			}

			Item item = hero.Bag.GetItem(args[1]);
			hero.UseItem(item);
			
			return $"{hero.Name} used {item.GetType().Name}.";

		}

		public string GetStats()
		{
			StringBuilder result = new StringBuilder();

            foreach (Character hero in characters
				.OrderByDescending(x => x.IsAlive)
				.ThenByDescending(x =>x.Health))
            {
				string status = hero.IsAlive ? "Alive" : "Dead";
				result.AppendLine($"{hero.Name} - HP: {hero.Health}/{hero.BaseHealth}, AP: {hero.Armor}/{hero.BaseArmor}, Status: {status}");
            }

			return result.ToString().TrimEnd();
		}

		public string Attack(string[] args) //FIX
		{
			//attackerName – args[0]
			//receiverName – args[1]

            if (characters.Any(x => x.Name == args[0]) == false)
            {
				throw new ArgumentException($"Character {args[0]} not found!");
            }

            if (characters.Any(x => x.Name == args[1]) == false)
            {
				throw new ArgumentException($"Character {args[1]} not found!");
			}

            if (characters.FirstOrDefault(x => x.Name == args[0]).GetType().Name != "Warrior")
            {
				throw new ArgumentException($"{args[0]} cannot attack!");
			}


			Warrior attacker = (Warrior)characters.FirstOrDefault(x => x.Name == args[0]);
			Character receiver = characters.FirstOrDefault(x => x.Name == args[1]);

            if (attacker.IsAlive == false)
            {
				throw new ArgumentException($"{attacker.Name} cannot attack!");
			}

			attacker.Attack(receiver);

			StringBuilder result = new StringBuilder();
			result.AppendLine
				($"{attacker.Name} attacks {receiver.Name} for " +
                $"{attacker.AbilityPoints} hit points! " +
                $"{receiver.Name} has {receiver.Health}/{receiver.BaseHealth} HP " +
                $"and {receiver.Armor}/{receiver.BaseArmor} AP left!");

            if (receiver.IsAlive == false)
            {
				result.AppendLine($"{receiver.Name} is dead!");
            }

			return result.ToString().TrimEnd();
		}

		public string Heal(string[] args)
		{
			//healerName – args[0]
			//healingReceiverName – args[1]			

			if (characters.Any(x => x.Name == args[0]) == false)
			{
				throw new ArgumentException($"Character {args[0]} not found!");
			}

			if (characters.Any(x => x.Name == args[1]) == false)
			{
				throw new ArgumentException($"Character {args[1]} not found!");
			}

            if (characters.FirstOrDefault(n => n.Name == args[0]).GetType().Name != "Priest")
            {
				throw new ArgumentException($"{args[0]} cannot heal!");
			}

			Priest healer = (Priest)characters.FirstOrDefault(x => x.Name == args[0]);
			Character receiver = characters.FirstOrDefault(x => x.Name == args[1]);

			if (healer.IsAlive == false)
			{
				throw new ArgumentException($"{args[0]} cannot heal!");
			}

			healer.Heal(receiver);

			return $"{healer.Name} heals {receiver.Name} for {healer.AbilityPoints}! {receiver.Name} has {receiver.Health} health now!";

		}
	}
}
