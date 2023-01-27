using Cashback.Application.Dto;
using Cashback.Domain.Entities;

namespace Cashback.Application.Factories
{
    public static class Factory
    {
        public static UserEntity CreateUserEntity(string name, string email, string password, string phoneNumber, CashbackEntity cashback)
        {
            return new UserEntity(name, email, password, phoneNumber, cashback);
        }
    }
}