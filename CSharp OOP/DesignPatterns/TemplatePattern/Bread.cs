using System;
namespace TemplatePattern
{
    public abstract class Bread
    {
        public abstract void MixIngredients();

        public abstract void Bake();

        public virtual void Slice()
        {
            Console.WriteLine("Slicing the " + GetType().Name + " bread!");
        }


        //Template method defines the order of making bread
        public void Make()
        {
            MixIngredients();
            Bake();
            Slice();
        }
    }
}
