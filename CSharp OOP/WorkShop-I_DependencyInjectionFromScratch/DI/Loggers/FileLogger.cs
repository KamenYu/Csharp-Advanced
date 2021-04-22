using System;
using System.IO;
using DI.Contracts;

namespace DI.Loggers
{
    public class FileLogger : ILogger
    {
        public FileLogger()
        {

        }

        public void Log(string message)
        {
            using (StreamWriter writer = new StreamWriter("../../../logs.txt", true))
            {
                writer.WriteLine(message);
            }
        }
    }
}
