using Cashback.Application.Interfaces;
using Cashback.Domain.Entities;
using Cashback.Repository.Interfaces;
using Cashback.Repository.Repositories;

namespace Cashback.Application.Factories
{
    public class FactoryRepositories : IFactoryRepositories
    {
        public static FactoryRepositories Instance()
        {
            return new FactoryRepositories();
        }

        public IBaseRepository<UserEntity> CreateUserRepository()
        {
            return new UserRepository();
        }
    }
}