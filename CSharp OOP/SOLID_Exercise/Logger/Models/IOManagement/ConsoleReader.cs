using System;
using Logger.Models.Contracts;

namespace Logger.Models.IOManagement
{
    public class ConsoleReader :IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
