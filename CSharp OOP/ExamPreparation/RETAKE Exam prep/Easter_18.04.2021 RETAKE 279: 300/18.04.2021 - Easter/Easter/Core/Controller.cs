using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Easter.Core.Contracts;
using Easter.Repositories.Contracts;
using Easter.Models.Eggs.Contracts;
using Easter.Models.Bunnies.Contracts;
using Easter.Repositories;
using Easter.Models.Bunnies;
using Easter.Models.Dyes;
using Easter.Models.Eggs;
using Easter.Models.Workshops;

namespace Easter.Core
{
    public class Controller : IController
    {
        private IRepository<IBunny> bunnies;
        private IRepository<IEgg> eggs;
        private Workshop ws;

        public Controller()
        {
            bunnies = new BunnyRepository();
            eggs = new EggRepository();
            ws = new Workshop();
        }

        public string AddBunny(string bunnyType, string bunnyName)
        {
            if (bunnyType == "HappyBunny")
            {
                bunnies.Add(new HappyBunny(bunnyName));
                return $"Successfully added {bunnyType} named {bunnyName}.";
            }
            else if (bunnyType == "SleepyBunny")
            {
                bunnies.Add(new SleepyBunny(bunnyName));
                return $"Successfully added {bunnyType} named {bunnyName}.";
            }
            else
            {
                throw new InvalidOperationException("Invalid bunny type");
            }
        }

        public string AddDyeToBunny(string bunnyName, int power)
        {
            IBunny bunny = bunnies.FindByName(bunnyName);
            if (bunny == null)
            {
                throw new InvalidOperationException("The bunny you want to add a dye to doesn't exist!");
            }

            bunny.AddDye(new Dye(power));

            return $"Successfully added dye with power {power} to bunny {bunnyName}!";
        }

        public string AddEgg(string eggName, int energyRequired)
        {
            eggs.Add(new Egg(eggName, energyRequired));

            return $"Successfully added egg: {eggName}!";
        }

        public string ColorEgg(string eggName)
        {
            List<IBunny> readyToDye = bunnies.Models.Where(x => x.Energy >= 50).ToList();
            IEgg egg = eggs.FindByName(eggName);

            if (readyToDye.Count == 0)
            {
                throw new InvalidOperationException("There is no bunny ready to start coloring!");
            }

            foreach (var b in readyToDye)
            {
                ws.Color(egg, b);

                if (b.Energy <= 0)
                {
                    bunnies.Remove(b);
                }

                if (egg.IsDone())
                {
                    break;
                }
            }

            string result = egg.IsDone() ? "done" : "not done";
            return $"Egg {eggName} is {result}.";
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();

            int doneEggs = eggs.Models.Select(x => x.IsDone()).Count();
            result.AppendLine($"{doneEggs} eggs are done!");
            result.AppendLine("Bunnies info:");

            foreach (var b in bunnies.Models)
            {
                result.AppendLine($"Name: {b.Name}");
                result.AppendLine($"Energy: {b.Energy}");
                result.AppendLine($"Dyes: {b.Dyes.Select(x => x.IsFinished() == true).Count()} not finished");
            }

            return result.ToString().TrimEnd();
        }
    }
}
