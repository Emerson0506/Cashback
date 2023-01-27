using Cashback.Domain.Interfaces;

namespace Cashback.Domain.Entities
{
    public class UserEntity : BaseEntity, IUser, IListedPeople
    {
        public List<ProcedimentEntity> Procediments { get; set; } = new();
        public List<IndicatedEntity> Indicateds { get; set; } = new();

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }

        public UserEntity(string name, string email, string password, string phoneNumber, CashbackEntity cashback)
        {
            Name = name;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            Cashback = cashback;

        }
    }
}