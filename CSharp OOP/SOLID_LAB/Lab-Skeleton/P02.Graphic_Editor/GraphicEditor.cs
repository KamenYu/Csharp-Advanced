namespace P02.Graphic_Editor
{
    public class GraphicEditor
    {
        public void DrawShape(IShape shape, string s)
        {
            IDrawingStrategy strategy = null;

            if (s.ToLower() == "circle")
            {
                strategy = new Circle();
            }
            else if (s.ToLower() == "square")
            {
                strategy = new Square();
            }
            else if (s.ToLower() == "rectangle")
            {
                strategy = new Rectangle();
            }

            strategy.DrawShape(shape);
        }
    }
}
