using System;
using DI.Contracts;

namespace DI.Loggers
{
    public class ConsoleLogger : ILogger
    { 
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
