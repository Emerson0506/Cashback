namespace Cashback.Domain.Interfaces
{
    public interface IIndicated
    {
        string CPF { get; set; }
        decimal Credit { get; set; }
        string IndicatedName { get; set; }
    }
}