using Cashback.Domain.Interfaces;

namespace Cashback.Domain.Entities
{
    public class IndicatedEntity : BaseEntity, IIndicated, IListedPeople
    {
        public string IndicatedName { get; set; }
        public string CPF { get; set; }
        public decimal Credit { get; set; }
        public List<ProcedimentEntity> Procediments { get; set; } = new();
        public List<IndicatedEntity> Indicateds { get; set; } = new();

        public IndicatedEntity(string name, string cPF, decimal credit)
        {
            IndicatedName = name;
            CPF = cPF;
            Credit = credit;
        }
    }
}