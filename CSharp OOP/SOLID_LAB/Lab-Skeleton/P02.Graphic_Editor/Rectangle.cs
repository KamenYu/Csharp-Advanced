namespace P02.Graphic_Editor
{
    public class Rectangle : IDrawingStrategy, IShape
    {
        public void DrawShape(IShape shape)
        {
            System.Console.WriteLine("I am a rectangle");
        }
    }
}
