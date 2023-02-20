namespace Cashback.Domain.Interfaces
{
    /// <summary>
    /// Contém informações para efetuar o procedimento.
    /// </summary>
    public interface IProcediment
    {
        /// <summary>
        /// CPF do paciente.
        /// </summary>
        string CPFClient { get; set; }

        /// <summary>
        /// Nome do procedimento.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Nome do Paciente.
        /// </summary>
        string NamePacient { get; set; }

        /// <summary>
        /// Valor do procedimento.
        /// </summary>
        decimal Value { get; set; }
        /// <summary>
        /// Telefone do paciente
        /// </summary>
        string PhoneNumber { get; set; }
        IClient Client { get; set; }
    }
}