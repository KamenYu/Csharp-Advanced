using System.Collections.Generic;

using Logger.Models.Contracts;

namespace Logger.Models
{
    public class Logg : ILogger
    {
        private readonly ICollection<IAppender> appenders;

        public Logg(ICollection<IAppender> appenders)
        {
            this.appenders = appenders;
        }

        public Logg(params IAppender[] appenders)
        {
            this.appenders = appenders;
        }

        public IReadOnlyCollection<IAppender> Appenders
            => (IReadOnlyCollection<IAppender>)appenders;

        public void Log(IError error)
        {
            foreach (IAppender item in appenders)
            {
                if (error.Level >= item.Level)
                {
                    item.Append(error);
                }
            }
        }
    }
}
