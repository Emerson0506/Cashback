using Cashback.Domain.Entities;

namespace Cashback.Domain.Interfaces
{
    public interface IUser
    {
        string Name { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        string PhoneNumber { get; set; }
        List<ProcedimentEntity> Procediments { get; }
        List<IndicatedEntity> Indicateds { get; }
    }
}