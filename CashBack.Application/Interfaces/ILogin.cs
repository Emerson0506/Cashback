using Cashback.Application.Dto;

namespace Cashback.Application.Interfaces
{
    public interface ILogin
    {
        public BaseDto ExecuteLogin(string email, string password);
    }
}