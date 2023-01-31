using Cashback.Application.Interfaces;
using Cashback.Application.Services;
using Cashback.Domain.Entities;
using Cashback.Repository.Interfaces;

namespace Cashback.Application.Factories
{
    public class FactoryServices
    {
        private static readonly IBaseRepository<UserEntity> _repositories = FactoryRepositories.Instance().CreateUserRepository();

        public static FactoryServices Instance()
        {
            return new FactoryServices();
        }

        public static ILogin CreateLoginService()
        {
            return new LoginService();
        }
    }
}