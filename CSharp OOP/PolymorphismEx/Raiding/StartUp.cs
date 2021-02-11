using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<BaseHero> raiders = new List<BaseHero>();
            BaseHero hero = null;

            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            while (counter != n)
            {           
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                if (IsValid(type))
                {
                    if (type == "Druid")
                    {
                        hero = new Druid(name);
                    }
                    else if (type == "Paladin")
                    {
                        hero = new Paladin(name);
                    }
                    else if (type == "Rogue")
                    {
                        hero = new Rogue(name);

                    }
                    else if (type == "Warrior")
                    {
                        hero = new Warrior(name);
                    }

                    counter++;
                    Console.WriteLine(hero.CastAbility());
                    raiders.Add(hero);
                }                
                else
                {
                    Console.WriteLine("Invalid hero!");
                }                
            }

            int bossPower = int.Parse(Console.ReadLine());

            int allPower = raiders.Select(x => x.Power).Sum();

            if (allPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }

        private static bool IsValid(string type)
        {
            if (type == "Druid" || type == "Paladin" || type == "Warrior" || type == "Rogue")
            {
                return true;
            }

            return false;
        }
    }
}
