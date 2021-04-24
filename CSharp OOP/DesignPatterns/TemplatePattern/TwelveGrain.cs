using System;
namespace TemplatePattern
{
    public class TwelveGrain : Bread
    {
        public override void Bake()
        {
            Console.WriteLine("Baking twelve grain - 25'.");
        }

        public override void MixIngredients()
        {
            Console.WriteLine("Gathering the seeds!");
        }
    }
}
