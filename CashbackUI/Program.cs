using Cashback.Application;
using Microsoft.Extensions.DependencyInjection;

namespace CashbackUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            IConfiguration configuration  = new Configure();

            var provider = new Provider(configuration);

            ApplicationConfiguration.Initialize();
            Application.Run(provider.Hosting.Services.GetRequiredService<MainForm>());
        }
    }
}