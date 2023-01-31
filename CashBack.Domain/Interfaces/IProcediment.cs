namespace Cashback.Domain.Interfaces
{
    public interface IProcediment
    {
        string CPFClient { get; set; }
        string Name { get; set; }
        string NamePacient { get; set; }
        decimal Value { get; set; }
    }
}