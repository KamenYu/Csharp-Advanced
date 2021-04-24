using System;
namespace CompositePattern2
{
    public class SimpleShape : IDrawable
    {
        public SimpleShape(string name)
        {
            Name = name;
        }

        public string Name { get; set ; }

        public void AddChild(IDrawable child)
        {
            throw new ArgumentException();
        }

        public void Draw(int level)
        {
            Console.Write(new string(' ', level));
            Console.WriteLine(Name);
        }
    }
}
