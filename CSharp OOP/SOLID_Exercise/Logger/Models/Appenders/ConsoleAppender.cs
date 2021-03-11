using System;
using Logger.Models.Common;
using Logger.Models.Contracts;
using Logger.Models.Enums;
using Logger.Models.IOManagement;

namespace Logger.Models.Appenders
{
    public class ConsoleAppender : Appender
    {
        private readonly IWriter writer;

        public ConsoleAppender(ILayout layout, Level level)
            :base(layout, level)
        {
            writer = new ConsoleWriter();
        }

        public override void Append(IError error)
        {
            string format = Layout.Format;
            DateTime dateTime = error.DateTime;
            string msg = error.Message;
            Level level = error.Level;

            string formated = string.Format
                (dateTime.ToString(GlobalConstants.DateTimeFormat),
                level.ToString(),
                msg);

            writer.WriteLine(formated);
            msgsAppended++;
        }
    }
}
