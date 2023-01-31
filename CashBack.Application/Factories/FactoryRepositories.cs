using Cashback.Application.Interfaces;
using Cashback.Domain.Entities;
using Cashback.Repository.Repositories;
using Pizzaria.Repository.Interfaces;

namespace Cashback.Application.General
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