using System;
using P02._DrawingShape_Before.Contracts;

namespace P02._DrawingShape_Before.Strategies
{
    public class RectangleDrawer : IDrawingStrategy
    {
        public void Draw(IShape shape)
        {
            var rectangle = shape as Rectangle;
            Console.WriteLine("Drawig rectangle");
        }

        public bool IsMatch(IShape shape)
        {
            return shape is Rectangle;
        }
    }
}
