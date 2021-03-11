using System;
using System.Collections.Generic;

using Logger.Models.Common;
using Logger.Models.Contracts;
using Logger.Models.Enums;
using Logger.Models.Factories;
using Logger.Models;
using Logger.Models.IOManagement;
using Logger.Models.PathManagement;
using Logger.Models.Files;
// UNFINISHED
namespace Logger
{
    public class StartUp
    {
        private static readonly LayoutFactory layoutFactory = new LayoutFactory();
        private static readonly AppenderFactory appenderFactory = new AppenderFactory();


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IPathManager pathManager = new PathManager("logs", "logs.txt");
            IFile file = new LogFile(pathManager);
            ILogger logger = SetupLogger(n, reader, writer, file);


        }

        private static ILogger SetupLogger(int appendersCount, IReader reader, IWriter writer, IFile file)
        {
            ICollection<IAppender> appenders = new HashSet<IAppender>();

            for (int i = 0; i < appendersCount; i++)
            {
                string[] appenderArgs = reader.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string appenderType = appenderArgs[0];
                string layoutType = appenderArgs[1];

                bool hasError = false;
                Level level = ParseLevel(appenderArgs, writer, ref hasError);

                if (hasError)
                {
                    continue;
                }


                try
                {
                    ILayout layout = layoutFactory.CreateLayout(layoutType);
                    IAppender appender = appenderFactory.CreateAppender(appenderType, layout, level, file);
                    appenders.Add(appender);
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }  
            }

            ILogger logger = new Logg(appenders);
            return logger;
        }

        private static Level ParseLevel(string[] levelString, IWriter writer, ref bool hasError)
        {
            Level appenderLevel = Level.INFO;
            if (levelString.Length == 3)
            {
                bool isEnumValid = Enum.TryParse(typeof(Level),
                    levelString[2], true, out object enumParsed);

                if (isEnumValid == false)
                {
                    writer.WriteLine
                        (GlobalConstants.InvalidLevelType);
                    hasError = true;
                }

                appenderLevel = (Level)enumParsed;
            }

            return appenderLevel;
        }
    }
}
