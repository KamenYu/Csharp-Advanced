using Microsoft.Extensions.DependencyInjection;
using MicrosoftDI.Contracts;
using MicrosoftDI.Loggers;

namespace MicrosoftDI
{
    public class ServiceConfiguratior
    {
        // we register all dependencies in here
        public static ServiceProvider ConfigureServices()
        {
            var serviceColletion = new ServiceCollection();

            //serviceColletion.AddTransient<ILogger, ConsoleLogger>();
            serviceColletion.AddTransient<ILogger, FileLogger>(f => new FileLogger("../../../fileLog.txt"));
            //if someone wants an ILogger, give him ConsoleLogger

            serviceColletion.AddTransient<Engine, Engine>();
            //if someone wants an Engine, give him Engine

            serviceColletion.AddTransient<IMovement, GameMovement>();

            return serviceColletion.BuildServiceProvider();
        }
    }
}
