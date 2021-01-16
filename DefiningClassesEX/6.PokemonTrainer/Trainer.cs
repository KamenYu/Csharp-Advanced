using System.Collections.Generic;

namespace _6.PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name, int badges, List<Pokemon> pokemons)
        {
            Name = name;
            AmountOfBadges = badges;
            Pokemons = pokemons;
        }

        public string Name { get; set; }

        public int AmountOfBadges { get; set; } = 0;

        public List<Pokemon> Pokemons { get; set; } = new List<Pokemon>();

    }
}
