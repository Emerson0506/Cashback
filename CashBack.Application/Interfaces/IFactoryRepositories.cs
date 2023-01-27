using Cashback.Domain.Entities;
using Cashback.Repository.Interfaces;

namespace Cashback.Application.Interfaces
{
    public interface IFactoryRepositories
    {
        IBaseRepository<UserEntity> CreateUserRepository();
    }
}
