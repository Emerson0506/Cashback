using Cashback.Domain.Entities;

namespace Cashback.Domain.Interfaces
{
    /// <summary>
    /// Contrato para as entidades que contem listas de <see cref="ProcedimentEntity"/> e <see cref="IndicatedEntity"/>
    /// </summary>
    public interface IListedPeople
    {
        /// <summary>
        /// Lista dos procedimentos realizados.
        /// </summary>
        List<ProcedimentEntity> Procediments { get; set; }

        /// <summary>
        /// Lista das pessoas indicadas.
        /// </summary>
        List<IndicatedEntity> Indicateds { get; set; }
    }
}