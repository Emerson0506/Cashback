using Cashback.Domain.Entities;

namespace Cashback.Repository.Repositories
{
    public class UserRepository : BaseRepository<UserEntity>
    {
        public UserRepository() : base("User")
        {
        }
    }
}