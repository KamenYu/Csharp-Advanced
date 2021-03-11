namespace P02.Graphic_Editor
{
    public class Circle : IDrawingStrategy, IShape
    {
        public void DrawShape(IShape shape)
        {
            System.Console.WriteLine("I am a circle");
        }
    }
}
