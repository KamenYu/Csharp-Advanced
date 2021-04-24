using System;
namespace CompositePattern.DrawingComponents
{
    public class Rectangle : Component
    {
        public Rectangle(Position position, int size) : base(position)
        {
            Size = size;
        }

        public int Size { get; set; }

        public override void Draw()
        {
            Console.SetCursorPosition(Position.X, Position.Y);

            for (int i = 1; i <= Size; i++)
            {
                for (int j = 1; j <= Size; j++)
                {
                    Console.Write("@");
                }

                Console.SetCursorPosition(Position.X, Position.Y + i);
            }

            base.Draw();
        }
    }
}
