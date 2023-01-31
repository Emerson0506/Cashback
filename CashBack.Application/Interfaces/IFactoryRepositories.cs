using Cashback.Domain.Entities;
using Pizzaria.Repository.Interfaces;

namespace Cashback.Application.Interfaces
{
    public interface IFactoryRepositories
    {
        IBaseRepository<UserEntity> CreateUserRepository();
    }
}
