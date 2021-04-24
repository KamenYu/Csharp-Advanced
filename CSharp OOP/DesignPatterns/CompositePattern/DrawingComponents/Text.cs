using System;
namespace CompositePattern.DrawingComponents
{
    public class Text : Leaf
    {
        public Text(Position position, int size, string text) : base(position)
        {
            Size = size;
            TextToType = text;
        }

        public int Size { get; set; }
        public string TextToType { get; set; }

        public override void Draw()
        {
            Console.SetCursorPosition(Position.X, Position.Y);
            Console.Write(TextToType);
            base.Draw();
        }
    }
}
