using System;
using DI.Containers;
using DI.Contracts;
using DI.Loggers;

namespace DI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ILogger logger = new ConsoleLogger(); // here using new is not a big deal
            //// however when the app grows there will be many more new instances of new classes
            //// so the solution is IoC
            //Engine e = new Engine(logger); //            
            
            //e.Start();
            //e.End();

            IContainer container = new SnakeGameContainer();
            container.ConfigureServices();
            Injector injector = new Injector(container);
            Engine e = injector.Inject<Engine>();

            e.Start();
            e.End();
        }
    }
}
