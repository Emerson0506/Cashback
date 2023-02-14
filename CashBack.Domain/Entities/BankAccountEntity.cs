using Cashback.Domain.Interfaces;

namespace Cashback.Domain.Entities
{
    /// <summary>
    /// Entidade da conta do banco do usuário.
    /// </summary>
    public class BankAccountEntity : IBankAccount
    {
        public decimal Balance { get; set; }
        public BankAccountEntity(decimal balance)
        {
            Balance = balance;
        }
        public BankAccountEntity()
        {

        }
    }
}