using Cashback.Application;
using Microsoft.Extensions.DependencyInjection;

namespace CashbackUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Setup setup = new(new Configure());

            var host = setup.CreateHostBuilder().Build();

            ApplicationConfiguration.Initialize();
            Application.Run(host.Services.GetRequiredService<MainForm>());
        }

    }
}