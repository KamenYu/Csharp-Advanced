using System;
using System.Collections.Generic;

namespace CompositePattern2
{
    public class ComplexShape : IDrawable
    {
        private List<IDrawable> shapes;
        public ComplexShape(string name)
        {
            shapes = new List<IDrawable>();
            Name = name;
        }

        public string Name { get; set; }

        public void AddChild(IDrawable child)
        {
            shapes.Add(child);
        }

        public void Draw(int level)
        {
            Console.Write(new string(' ', level));
            Console.WriteLine(Name);

            foreach (IDrawable item in shapes)
            {
                item.Draw(level + 3);
            }
        }
    }
}
