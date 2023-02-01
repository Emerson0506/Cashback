namespace Cashback.Domain.Interfaces
{
    /// <summary>
    /// Contém informações dos indicados.
    /// </summary>
    public interface IIndicated
    {
        /// <summary>
        /// CPF do indicado.
        /// </summary>
        string CPF { get; set; }

        /// <summary>
        /// Crédito do indicado referente a indicação na clínica.
        /// </summary>
        decimal Credit { get; set; }
        /// <summary>
        /// Nome do indicado.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Nome do indicador.
        /// </summary>
        string IndicatorName { get; set; }
    }
}