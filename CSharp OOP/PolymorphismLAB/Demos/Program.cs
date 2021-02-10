using System;

namespace Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Rectangle() { A = 5, B = 6};
            Console.WriteLine(shape.Area());
            shape = new Square() { A = 15 };
            Console.WriteLine(shape.Area());
        }
    }
}
