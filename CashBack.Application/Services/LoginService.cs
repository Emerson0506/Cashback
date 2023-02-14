using Cashback.Application.Dto;
using Cashback.Application.Extensions;
using Cashback.Application.Interfaces;
using Cashback.Domain.Entities;
using Cashback.Repository.Interfaces;

namespace Cashback.Application.Services
{

    /// <summary>
    /// Efetua login do usuário e implementa <see cref="ILogin"/>
    /// </summary>
    public class LoginService : ILogin
    {
        private readonly IBaseRepository<UserEntity> _userRepository;

        public LoginService(IBaseRepository<UserEntity> userRepository)
        {
            _userRepository = userRepository;
        }



        /// <summary>
        /// Efetua o login do usuário com os parâmetros fornecidos.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns>Retorna um tipo <see cref="BaseDto"/> com StatusCode 200 e Id do usuário em caso de sucesso, ou 404 em caso de falha.</returns>
        public BaseDto ExecuteLogin(string email, string password)
        {
            var user = _userRepository.GetAll().Find(x => x.Email == email && x.Password == password);

            if (user == null)
                return BaseDtoExtension.NotFound();

            return BaseDtoExtension.Create(200, "Login executado", user.Id);
        }
    }
}