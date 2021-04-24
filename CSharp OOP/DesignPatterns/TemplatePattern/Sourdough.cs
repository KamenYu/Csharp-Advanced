using System;
namespace TemplatePattern
{
    public class Sourdough : Bread
    {

        public override void Bake()
        {
            Console.WriteLine("Baking Sourdough - 20'.");
        }

        public override void MixIngredients()
        {
            Console.WriteLine("Waiting for the dough to sour");
        }
    }
}
