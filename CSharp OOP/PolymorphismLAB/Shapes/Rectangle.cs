namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double h, double w)
        {
            height = h;
            width = w;
        }

        public override double CalculateArea()
        {
            return width * height;
        }

        public override double CalculatePerimeter()
        {
            return height * 2 + width * 2;
        }

        public override string Draw()
        {
            return base.Draw() + " Rectangle";
        }
    }
}
