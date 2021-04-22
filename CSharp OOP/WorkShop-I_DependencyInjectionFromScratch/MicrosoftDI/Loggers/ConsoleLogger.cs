using System;
using MicrosoftDI.Contracts;

namespace MicrosoftDI.Loggers
{
    public class ConsoleLogger : ILogger
    { 
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
