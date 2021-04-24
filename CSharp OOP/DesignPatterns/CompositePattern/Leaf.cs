namespace CompositePattern
{
    public class Leaf : Component
    {
        // Leaf is the last element that cannot hold anything inside itself
        public Leaf(Position position) : base(position)
        { }

        public override void Add(IComponent component)
        { }

        public  override void Remove(IComponent component)
        { }
    }
}
