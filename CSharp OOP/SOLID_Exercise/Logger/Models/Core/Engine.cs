using System;
using Logger.Models.Contracts;
using Logger.Models.Enums;
using Logger.Models.Factories;

namespace Logger.Models.Engine
{// UNFINISHED
    public class Engine : IEngine
    {
        private readonly ILogger logger;
        private readonly IReader reader;
        private readonly IWriter writer;

        public Engine(ILogger logger, IReader reader, IWriter writer)
        {
            this.logger = logger;
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            string command;
            while ((command = reader.ReadLine()) != "END")
            {
                string[] errorArsg = command.Split();
                string levelStr = errorArsg[0];
                string dTime = errorArsg[1];
                string msg = errorArsg[2];

                Level level;
                bool isLevelValid = Enum.TryParse(typeof(Level),levelStr, true, out object levelObj);

                if (isLevelValid == false)
                {

                }

                try
                {
                    

                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
