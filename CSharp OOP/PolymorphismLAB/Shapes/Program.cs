using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Shape shape = new Rectangle(3.5, 12);
            Shape shape1 = new Circle(1);

            Console.WriteLine($"Perimeter = {shape.CalculatePerimeter():f2}; \nArea = {shape.CalculateArea():f2}; \n{shape.Draw()}");
            Console.WriteLine($"Perimeter = {shape1.CalculatePerimeter():f2}; \nArea = {shape1.CalculateArea():f2}; \n{shape1.Draw()}");
        }
    }
}
