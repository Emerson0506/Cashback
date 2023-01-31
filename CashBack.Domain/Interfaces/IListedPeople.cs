using Cashback.Domain.Entities;

namespace Cashback.Domain.Interfaces
{
    /// <summary>
    /// Contrato para as entidades que contem listas de <see cref="ProcedimentEntity"/> e <see cref="IndicatedEntity"/>
    /// </summary>
    public interface IListedPeople
    {
        List<ProcedimentEntity> Procediments { get; set; }
        List<IndicatedEntity> Indicateds { get; set; }
    }
}