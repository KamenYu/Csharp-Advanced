using System;
namespace IteratorsDemo
{
    public interface IPrintable
    {
        // only props and methods
        public void Print();
        // only what is in the interface, not what will be the implementation
        public void Endgame(bool isOver);
    }
}
