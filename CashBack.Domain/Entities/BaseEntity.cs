namespace Cashback.Domain.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public CashbackEntity Cashback { get; set; }
    }
}