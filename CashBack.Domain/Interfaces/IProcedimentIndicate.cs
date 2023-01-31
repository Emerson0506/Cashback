using Cashback.Domain.Entities;

namespace Cashback.Domain.Interfaces
{
    public interface IProcedimentIndicate
    {
        public List<ProcedimentEntity> Procediments { get; set; }
        public List<IndicatedEntity> Indicateds { get; set; }

    }
}