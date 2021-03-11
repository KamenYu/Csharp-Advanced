using System;
using System.IO;
using Logger.Models.Contracts;

namespace Logger.Models.IOManagement
{
    public class FileWriter : IWriter
    {
        public FileWriter(string path)
        {
            FilePath = path;
        }

        public string FilePath { get; set; }

        public void Write(string text)
        {
            File.WriteAllText(FilePath, text);
        }

        public void WriteLine(string text)
        {
            File.WriteAllText(FilePath, text + Environment.NewLine);
        }
    }
}
