using System;
using System.IO;
using MicrosoftDI.Contracts;

namespace MicrosoftDI.Loggers
{
    public class FileLogger : ILogger
    {
        private string path;
        public FileLogger(string path)
        {
            this.path = path;
        }

        public void Log(string message)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(message);
            }
        }
    }
}
