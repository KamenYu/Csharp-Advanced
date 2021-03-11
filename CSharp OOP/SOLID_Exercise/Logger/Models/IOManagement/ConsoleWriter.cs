using System;
using Logger.Models.Contracts;

namespace Logger.Models.IOManagement
{
    public class ConsoleWriter :IWriter
    {
        void IWriter.Write(string text)
        {
            Console.Write(text);
        }

        void IWriter.WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
