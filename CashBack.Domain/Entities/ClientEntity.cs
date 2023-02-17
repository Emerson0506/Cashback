using Cashback.Domain.Interfaces;

namespace Cashback.Domain.Entities
{
    /// <summary>
    /// Entidade do cliente,  implementa <see cref="IClient"/> e <see cref="IListedPeople"/>
    /// </summary>
    public class ClientEntity : BaseEntity, IClient, IListedPeople
    {
        public BankAccountEntity Account { get; set; } = new();
        public List<ProcedimentEntity> Procediments { get; set; } = new();
        public List<IndicatedEntity> Indicateds { get; set; } = new();
        public string Name { get; set; }
        public string CPF { get; set; }
        public string PhoneNumber { get; set; }

        public ClientEntity(string name, string cpf, string phoneNumber)
        {
            Name = name;
            CPF = cpf;
            PhoneNumber = phoneNumber;
        }
    }
}