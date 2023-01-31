using Cashback.Domain.Interfaces;

namespace Cashback.Domain.Entities
{
    public class ClientEntity : BaseEntity, IClient, IListedPeople
    {
        public BankAccountEntity Account { get; set; }
        public List<ProcedimentEntity> Procediments { get; set; } = new();
        public List<IndicatedEntity> Indicateds { get ; set; } = new();

        public ClientEntity(BankAccountEntity account, List<ProcedimentEntity> procediments, List<IndicatedEntity> indicateds, CashbackEntity cashback)
        {
            Account = account;
            Procediments = procediments;
            Indicateds = indicateds;
            Cashback = cashback;
        }
    }
}