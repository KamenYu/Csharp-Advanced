using System;
using DI.Attributes;
using DI.Contracts;

namespace DI
{
    
    public class Engine
    {
        private ILogger logger;
        private IReader reader;

        [Inject]
        public Engine(ILogger logger, IReader reader) // this is DI
        {
            this.logger = logger;
            this.reader = reader;
        }

        public void Start() { logger.Log("Starting..."); }
        public void End()   { logger.Log("End!"); }
    }
}
