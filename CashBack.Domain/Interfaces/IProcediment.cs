namespace Cashback.Domain.Interfaces
{
    /// <summary>
    /// Contém informações para efetuar o procedimento.
    /// </summary>
    public interface IProcediment
    {
        /// <summary>
        /// CPF do cliente.
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
    }
}