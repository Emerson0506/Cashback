using Cashback.Domain.Interfaces;

namespace Cashback.Domain.Entities
{
    /// <summary>
    /// Entidade de Indicados, implementa <see cref="IIndicated"/> e <see cref="IListedPeople"/>
    /// </summary>
    public class IndicatedEntity : BaseEntity, IIndicated, IListedPeople
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public decimal Credit { get; set; }
        public List<ProcedimentEntity> Procediments { get; set; } = new();
        public List<IndicatedEntity> Indicateds { get; set; } = new();
        public string IndicatorName { get; set; }
        public IndicatedEntity(string name, string cPF, string indicatorName)
        {
            Name = name;
            CPF = cPF;
            IndicatorName = indicatorName;
        }
    }
}