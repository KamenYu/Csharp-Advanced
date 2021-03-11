using System;
using System.IO;
using System.Linq;

using Logger.Models.Common;
using Logger.Models.Contracts;
using Logger.Models.Enums;

namespace Logger.Models.Files
{
    public class LogFile : IFile
    {
        private readonly IPathManager pathManager; // hmm
        public LogFile(IPathManager pathManager)
        {
            this.pathManager = pathManager;
            this.pathManager.DoDirectoryORFileExist();
        }

        public string Path => this.pathManager.CurrentFilePath;

        public long Size => CalculateFileSize();

        public string Write(ILayout layout, IError error)
        {
            string format = layout.Format;
            DateTime dateTime = error.DateTime;
            string message = error.Message;
            Level level = error.Level;
            string formatedMessage = string
                .Format(dateTime.ToString(GlobalConstants.DateTimeFormat)
                , level.ToString()
                , message);

            return formatedMessage;
        }

        private long CalculateFileSize()
        {
            string fileText = File.ReadAllText(this.Path);
            return fileText
                .ToCharArray()
                .Where(c => char.IsLetter(c))
                .Sum(c => c);
        }
    }
}
