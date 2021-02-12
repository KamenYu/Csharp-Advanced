using WildFarm.Contracts;

namespace WildFarm.Base
{
    public abstract class Food : IFood
    {
        protected Food(int quantity)
        {
            Quantity = quantity;
        }

        public int Quantity { get; }
    }
}
