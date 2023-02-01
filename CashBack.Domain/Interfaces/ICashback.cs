namespace Cashback.Domain.Interfaces
{
    /// <summary>
    /// Contém informações do Cashback.
    /// </summary>
    public interface ICashback
    {
        /// <summary>
        /// Valor do cashback.
        /// </summary>
        decimal ValueAmount { get; set; }
    }
}