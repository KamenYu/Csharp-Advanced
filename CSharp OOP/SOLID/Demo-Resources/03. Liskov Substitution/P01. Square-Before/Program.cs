using System;

namespace P01._Square_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Square shape = new Square();
            ChangeHeight(shape, 5);
        }

        static void ChangeHeight(Square sq, int newHeight)
        {
            sq.Height = newHeight;
        }
    }
}
