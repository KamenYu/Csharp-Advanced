using System;
using System.Collections;

namespace IteratorsDemo
{
    public class Game : IPrintable, IEnumerable
    {
        public void Endgame(bool isOver)
        {
            
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            
        }
    }
}
