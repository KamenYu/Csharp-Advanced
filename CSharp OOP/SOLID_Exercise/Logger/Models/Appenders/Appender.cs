using Logger.Models.Contracts;
using Logger.Models.Enums;

namespace Logger.Models.Appenders
{
    public abstract class Appender : IAppender
    {
        protected int msgsAppended;
        protected Appender(ILayout layout, Level level)
        {
            Layout = layout;
            Level = level;
        }

        public ILayout Layout { get; }

        public Level Level { get; }

        public abstract void Append(IError error);

        public override string ToString()
        {
            return
                $"Appender type: {GetType().Name}, " +
                $"Layout type: {Layout.GetType().Name}, " +
                $"Report level: {Level.ToString()}, " +
                $"Messages appended: {msgsAppended}";
        }
    }
}
