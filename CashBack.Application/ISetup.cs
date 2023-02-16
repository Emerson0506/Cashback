using Microsoft.Extensions.DependencyInjection;

namespace Cashback.Application
{
    public interface ISetup
    {
        void Inject(IServiceCollection services);
    }
}