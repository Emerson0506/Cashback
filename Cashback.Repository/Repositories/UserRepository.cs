using Cashback.Domain.Entities;
using Pizzaria.Repository.Repositories;

namespace Cashback.Repository.Repositories
{
    public class UserRepository : BaseRepository<UserEntity>
    {
        public UserRepository() : base("User")
        {
        }
    }
}