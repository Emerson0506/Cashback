using Cashback.Application.Dto;
using Cashback.Application.Extensions;
using Cashback.Application.Factories;
using Cashback.Application.Interfaces;
using Cashback.Domain.Entities;
using Cashback.Repository.Interfaces;
using System.Buffers.Text;

namespace Cashback.Application.Services
{
    public class LoginService : ILogin
    {
        private readonly IBaseRepository<UserEntity> _userRepository;

        private readonly IFactoryRepositories _factoryRepositories = FactoryRepositories.Instance();

        public LoginService()
        {
            _userRepository = _factoryRepositories.CreateUserRepository();
        }

        public BaseDto ExecuteLogin(string email, string password)
        {
            var user = _userRepository.GetAll().Find(x => x.Email == email && x.Password == password);

            if (user == null)
                return BaseDtoExtension.CreateBaseDto(404, "Usuario não encontrado");

            return BaseDtoExtension.CreateBaseDto(200, "Login executado", user.Id);
        }
    }
}