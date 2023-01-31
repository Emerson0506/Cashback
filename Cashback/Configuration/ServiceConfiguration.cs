using Cashback.Application.Services;

namespace Cashback.Configuration
{
    public class ServiceConfiguration
    {
        public static void Setup(IServiceCollection builder)
        {
            builder.AddSingleton<LoginService>();
            builder.AddSingleton<ProcedimentService>();
        }
    }
}