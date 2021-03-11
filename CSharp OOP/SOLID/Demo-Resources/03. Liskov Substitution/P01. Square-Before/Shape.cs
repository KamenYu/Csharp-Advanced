namespace P01._Square_Before
{
    public abstract class Shape
    {
        public abstract double Area { get; }

        public virtual int  Height { get; set; }
        public virtual int  Width { get; set; }
    }
}