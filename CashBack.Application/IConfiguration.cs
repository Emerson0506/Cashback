using Microsoft.Extensions.DependencyInjection;

namespace Cashback.Application
{
    public interface IConfiguration
    {
        void InjectForm(IServiceCollection services);
    }
}
