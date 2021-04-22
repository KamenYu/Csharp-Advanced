using System;
using DI.Attributes;
using DI.Contracts;

namespace DI.Readers
{
    public class ConsoleReader : IReader
    {
        private ILogger logger;

        [Inject]
        public ConsoleReader(ILogger logger)
        {
            this.logger = logger;
        }

        public string ReadKey()
        {
            logger.Log("Reading key_");
            return "";
        }

        public string ReadLine()
        {
            logger.Log("Reading a line_");
            return "";
        }
    }
}
