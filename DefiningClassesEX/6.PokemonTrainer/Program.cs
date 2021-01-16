using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            // "{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"
            string input = string.Empty;
            List<Trainer> trainers = new List<Trainer>();

            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string trainer = tokens[0];
                string pokemonName = tokens[1];
                string pElement = tokens[2];
                int pHP = int.Parse(tokens[3]);

                List<Pokemon> pokemons = new List<Pokemon>();
                Pokemon currentP = new Pokemon(pokemonName, pElement, pHP);
                Trainer existing = trainers.Where(x => x.Name == trainer).FirstOrDefault();
                if (trainers.Contains(existing))
                {
                    existing.Pokemons.Add(currentP);
                }
                else
                {
                    pokemons.Add(currentP);
                    Trainer currentT = new Trainer(trainer, 0, pokemons);
                    trainers.Add(currentT);
                }
            }

            while ((input = Console.ReadLine()) != "End")
            {
                foreach (var item in trainers)
                {
                    Pokemon pk = item.Pokemons.Where(x => x.Element == input).FirstOrDefault();

                    if (pk != null)
                    {
                        item.AmountOfBadges++;
                    }
                    else
                    {
                        List<Pokemon> differentPk = item.Pokemons.Where(x => x.Element != input).ToList();

                        foreach (var pok in differentPk)
                        {
                            pok.Health -= 10;

                            if (pok.Health <= 0)
                            {
                                item.Pokemons.Remove(pok);
                            }
                        }                                                  
                    }
                }
            }

            foreach (Trainer tr in trainers.OrderByDescending(x => x.AmountOfBadges))
            {
                Console.WriteLine($"{tr.Name} {tr.AmountOfBadges} {tr.Pokemons.Count}");
            }
        }
    }
}
