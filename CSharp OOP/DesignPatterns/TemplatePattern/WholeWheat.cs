using System;
namespace TemplatePattern
{
    public class WholeWheat : Bread
    {
        public override void Bake()
        {
            Console.WriteLine("Baking wholewheat - 15'.");
        }

        public override void MixIngredients()
        {
            Console.WriteLine("Worst dough ever, use lots of oil!");
        }
    }
}
