using Cashback.Application.Dto;
using Cashback.Domain.Entities;

namespace Cashback.Application.General
{
    public static class Factory
    {
        public static UserEntity CreateUserEntity(string name, string email, string password, string phoneNumber, CashbackEntity cashback)
        {
            return new UserEntity(name, email, password, phoneNumber, cashback);
        }

        public static BaseDto CreateBaseDto(int statusCode, string message, object? data = null)
        {
            return new BaseDto(statusCode, message, data);
        }
    }
}