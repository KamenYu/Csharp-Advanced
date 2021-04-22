using System;
using ViceCity.Core.Contracts;
using ViceCity.Core.Models;

namespace ViceCity
{
    class StartUp
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
