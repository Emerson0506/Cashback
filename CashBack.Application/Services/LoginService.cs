using Cashback.Application.Dto;
using Cashback.Application.General;
using Cashback.Application.Interfaces;
using Cashback.Domain.Entities;
using Pizzaria.Repository.Interfaces;

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
                return Factory.CreateBaseDto(404, "Usuario não encontrado");

            return Factory.CreateBaseDto(200, "Login executado", user.Id);
        }
    }
}