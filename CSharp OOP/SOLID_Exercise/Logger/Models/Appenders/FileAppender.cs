using System;
using Logger.Models.Contracts;
using Logger.Models.Enums;
using Logger.Models.IOManagement;

namespace Logger.Models.Appenders
{
    public class FileAppender : Appender
    {
        private readonly IWriter writer;
        public FileAppender(ILayout layout, Level level, IFile file)
            : base(layout, level)
        {
            File = file;
            writer = new FileWriter(File.Path);
        }


        public IFile File { get; }

        public override void Append(IError error)
        {
            string formatedMessage = File.Write(Layout, error);
            writer.WriteLine(formatedMessage);
            msgsAppended++;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, File size: {File.Size}";
        }
    }
}
