using Microsoft.Extensions.DependencyInjection;

namespace MicrosoftDI
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceProvider serviceProvider = ServiceConfiguratior.ConfigureServices();

            Engine e = serviceProvider.GetRequiredService<Engine>();
            e.Start();
            e.End();
        }
    }
}
