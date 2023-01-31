namespace Cashback.Domain.Entities
{
    public class CashbackEntity : BaseEntity
    {
        public decimal ValueAmount { get; set; }

        public CashbackEntity(decimal valueAmount)
        {
            ValueAmount = valueAmount;
        }
    }
}