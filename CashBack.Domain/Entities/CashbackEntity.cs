using Cashback.Domain.Interfaces;

namespace Cashback.Domain.Entities
{
    public class CashbackEntity : ICashback
    {
        public decimal ValueAmount { get; set; } = 2;

        public CashbackEntity(decimal valueAmount)
        {
            ValueAmount = valueAmount;
        }
    }
}