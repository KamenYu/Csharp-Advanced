using System;
using System.Threading;
using CompositePattern.DrawingComponents;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // used for announcements from top to bottom or drawing
            // check it visually, shows Composite pattern really well
            IComponent page = new Component(new Position(0, 0));
            page.Add(new Rectangle(new Position(0, 1), 7));
            //page.Add(new Rectangle(new Position(5, 10), 6));
            IComponent rec = new Rectangle(new Position(5, 10), 3);
            rec.Add(new Text(new Position(12, 0), 0, "I cannot lie"));
            rec.Add(new Text(new Position(13, 6), 1, "Rigmarole"));
            rec.Add(new Text(new Position(22, 9), 3, "Hodgepodge"));
            page.Add(rec);

            page.Draw();

            while (true)
            {
                Position movePosition = new Position(3, 1);
                Console.Clear();
                rec.Move(movePosition);
                //rec.Draw();
                page.Draw();
                Thread.Sleep(500);
            }

            //Rectangle rec = new Rectangle(new Position(8, 1), 5);
            //rec.Draw();
        }
    }
}
