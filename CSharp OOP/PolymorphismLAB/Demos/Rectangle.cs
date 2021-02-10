namespace Demos
{
    public class Rectangle : Shape
    {
        public int A { get; set; }

        public int B { get; set; }

        public override double Area()
        {
            return A * B;
        }
    }
}
