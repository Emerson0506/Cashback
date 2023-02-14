using Cashback.Domain.Entities;

namespace Cashback.Repository.Repositories
{
    public class IndicatedRepository : BaseRepository<IndicatedEntity>
    {
        public IndicatedRepository() : base("Indicates")
        {
        }
    }
}
