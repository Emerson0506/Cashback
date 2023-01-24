namespace Cashback.Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public CashbackEntity Cashback { get; set; }

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