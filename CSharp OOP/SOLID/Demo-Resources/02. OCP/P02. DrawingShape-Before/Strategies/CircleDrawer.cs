using System;
using P02._DrawingShape_Before.Contracts;

namespace P02._DrawingShape_Before.Strategies
{
    public class CircleDrawer : IDrawingStrategy
    {
        public void Draw(IShape shape)
        {
            var circle = shape as Circle;
            Console.WriteLine("Drawig circle");
        }

        public bool IsMatch(IShape shape)
        {
            return shape is Circle;
        }
    }
}
