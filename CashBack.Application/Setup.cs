using Cashback.Application.Interfaces;
using Cashback.Application.Services;
using Cashback.Domain.Entities;
using Cashback.Repository.Interfaces;
using Cashback.Repository.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Cashback.Application
{
    public class Setup : ISetup
    {
        private readonly IConfiguration _config;

        public Setup(IConfiguration configuration)
        {
            _config = configuration;
        }

        public void Inject(IServiceCollection services)
        {
            services.AddTransient<IProvide, Provider>();

            services.AddTransient<IBaseRepository<UserEntity>, UserRepository>();
            services.AddTransient<IBaseRepository<ClientEntity>, ClientRepository>();
            services.AddTransient<IBaseRepository<IndicatedEntity>, IndicatedRepository>();
            services.AddTransient<ILogin, LoginService>();
            services.AddTransient<RegisterService>();

            _config.InjectForm(services);
        }
    }
}