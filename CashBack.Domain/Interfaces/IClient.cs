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
        /// <summary>
        /// Nome do cliente.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// CPF do cliente.
        /// </summary>
        public string CPF { get; set; }
        /// <summary>
        /// Email do cliente.
        /// </summary>
        public string Email { get; set; }
    }
}