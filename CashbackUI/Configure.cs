using Cashback.Application;
using Microsoft.Extensions.DependencyInjection;

namespace CashbackUI
{
    internal class Configure : IConfiguration
    {
        public void InjectForm(IServiceCollection services)
        {
            services.AddTransient<MainForm>();
        }
    }
}