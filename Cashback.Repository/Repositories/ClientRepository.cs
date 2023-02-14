using Cashback.Domain.Entities;

namespace Cashback.Repository.Repositories
{
    public class ClientRepository : BaseRepository<ClientEntity>
    {
        public ClientRepository() : base("Client")
        {

        }
    }
}
