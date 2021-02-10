namespace Demos
{
    public class Square : Shape
    {
        public int A { get; set; }

        public override double Area()
        {
            return A * A;
        }
    }
}
