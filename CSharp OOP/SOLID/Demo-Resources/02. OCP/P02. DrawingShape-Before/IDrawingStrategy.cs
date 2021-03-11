using P02._DrawingShape_Before.Contracts;

namespace P02._DrawingShape_Before
{
    public interface IDrawingStrategy
    {
        void Draw(IShape shape);

        bool IsMatch(IShape shape);
    }
}
