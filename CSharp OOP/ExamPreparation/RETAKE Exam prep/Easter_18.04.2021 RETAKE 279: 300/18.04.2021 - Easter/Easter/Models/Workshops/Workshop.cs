using System;
using System.Linq;
using Easter.Models.Bunnies.Contracts;
using Easter.Models.Dyes.Contracts;
using Easter.Models.Eggs.Contracts;
using Easter.Models.Workshops.Contracts;

namespace Easter.Models.Workshops
{
    public class Workshop : IWorkshop
    {
        public Workshop()
        {
        }

        public void Color(IEgg egg, IBunny bunny)
        {
            while (bunny.Energy > 0 && bunny.Dyes.Any(d => d.Power > 0))
            {
                if (egg.IsDone())
                {
                    break;
                }

                IDye d = bunny.Dyes.FirstOrDefault(x => x.Power > 0);
                d.Use();
                bunny.Work();
                egg.GetColored();                
            }
        }
    }
}
