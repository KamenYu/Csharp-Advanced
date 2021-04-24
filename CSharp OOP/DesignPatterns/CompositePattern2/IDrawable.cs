﻿namespace CompositePattern2
{
    public interface IDrawable
    {
        public string Name { get; set; }

        void Draw(int level);

        void AddChild(IDrawable child);
    }
}
