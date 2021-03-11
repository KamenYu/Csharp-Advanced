namespace P02._DrawingShape_Before
{
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;
    using P02._DrawingShape_Before.Strategies;

    class DrawingManager : IDrawingManager
    {
        private List<IDrawingStrategy> strategies;

        public DrawingManager()
        {
            strategies = new List<IDrawingStrategy>()
            {
                new CircleDrawer(),
                new RectangleDrawer() // only in here there can be a modification, that is insignificant, thus better than using reflection
            };
        }

        public void Draw(IShape shape)
        {
            IDrawingStrategy drawer = strategies.First(s=> s.IsMatch(shape));

            drawer.Draw(shape);
        }
    }
}
