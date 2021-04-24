using System;

namespace TemplatePattern
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Sourdough s = new Sourdough();
            WholeWheat w = new WholeWheat();
            TwelveGrain t = new TwelveGrain();

            s.Make();
            w.Make();
            t.Make();
        }
    }
}
