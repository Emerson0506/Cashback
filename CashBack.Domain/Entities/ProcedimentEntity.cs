using Cashback.Domain.Interfaces;

namespace Cashback.Domain.Entities
{
    /// <summary>
    /// Entidade de procedimentos, implementa <see cref="IProcediment"/>
    /// </summary>
    public class ProcedimentEntity : IProcediment
    {
        public decimal Value { get; set; }
        public string Name { get; set; }
        public string CPFClient { get; set; }
        public string NamePacient { get; set; }
        public string PhoneNumber { get; set ; }
        public IClient Client { get; set; }

        public ProcedimentEntity(decimal value, string name, string cPFClient, string namePacient, string phoneNumber, IClient client)
        {
            Value = value;
            Name = name;
            CPFClient = cPFClient;
            NamePacient = namePacient;
            PhoneNumber = phoneNumber;
            Client = client;
        }
    }
}