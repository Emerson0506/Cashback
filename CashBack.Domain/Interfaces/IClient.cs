using Cashback.Domain.Entities;

namespace Cashback.Domain.Interfaces
{
    public interface IClient
    {
        BankAccountEntity Account { get; set; }
    }
}