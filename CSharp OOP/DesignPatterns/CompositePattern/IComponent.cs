namespace CompositePattern
{
    public interface IComponent
    {
        void Add(IComponent component);

        void Remove(IComponent component);

        void Draw();

        void Move(Position position);
    }
}
