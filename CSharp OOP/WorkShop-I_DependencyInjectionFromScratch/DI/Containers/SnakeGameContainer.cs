using System;
using DI.Contracts;
using DI.Loggers;
using DI.Readers;

namespace DI.Containers
{
    public class SnakeGameContainer : AbstractContainer
    {
        public override void ConfigureServices()
        {
            CreateMapping<ILogger, ConsoleLogger>();
            CreateMapping<IReader, ConsoleReader>();
        }
    }
}
