namespace P02.Graphic_Editor
{
    class Program
    {
        static void Main()
        {
            GraphicEditor gE = new GraphicEditor();
            gE.DrawShape(new Circle(), "circle");
        }
    }
}
