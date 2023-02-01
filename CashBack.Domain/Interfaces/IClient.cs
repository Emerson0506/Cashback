using Cashback.Domain.Entities;

namespace Cashback.Domain.Interfaces
{
    /// <summary>
    /// Contém informações do cliente.
    /// </summary>
    public interface IClient
    {
        /// <summary>
        /// Conta bancária do cliente.
        /// </summary>
        BankAccountEntity Account { get; set; }
    }
}