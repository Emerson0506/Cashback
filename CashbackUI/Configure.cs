using Cashback.Application;
using Microsoft.Extensions.DependencyInjection;

namespace CashbackUI
{
    public class Configure : IConfiguration
    {
        public void InjectForm(IServiceCollection services)
        {
            services.AddTransient<IConfiguration, Configure>();

            services.AddTransient<MainForm>();
            services.AddTransient<RegisterForm>();
        }
    }
}