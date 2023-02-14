using Cashback.Application.Dto;
using Cashback.Application.Extensions;
using Cashback.Application.Factories;
using Cashback.Domain.Entities;
using Cashback.Repository.Interfaces;

namespace Cashback.Application.Services
{
    /// <summary>
    /// Responsável pelos registros do usuário e do cliente.
    /// </summary>
    public class RegisterService
    {
        private readonly IBaseRepository<UserEntity> _userRepository;

        private readonly IBaseRepository<ClientEntity> _clientRepository;

        public RegisterService(IBaseRepository<UserEntity> userRepository, IBaseRepository<ClientEntity> clientRepository)
        {
            _userRepository = userRepository;
            _clientRepository = clientRepository;
        }



        /// <summary>
        /// Responsável pelo registro do usuário.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="phoneNumber"></param>
        /// <returns>Retorna <see cref="BaseDto"/> em caso de sucesso ou falha.</returns>
        public BaseDto User(string name, string email, string password, string phoneNumber)
        {
            if (string.IsNullOrEmpty(name))
                return BaseDtoExtension.InvalidValue("Nome Inválido");

            if (string.IsNullOrEmpty(email))
                return BaseDtoExtension.InvalidValue("Email Inválido");

            if (!email.Contains("@") || !email.ToUpper().Contains(".COM"))
                return BaseDtoExtension.InvalidValue("Email Inválido");

            if (string.IsNullOrEmpty(password))
                return BaseDtoExtension.InvalidValue("Digite uma senha!");

            if (password.Length < 3)
                return BaseDtoExtension.InvalidValue("Digite uma senha segura!");

            if (string.IsNullOrEmpty(phoneNumber))
                return BaseDtoExtension.InvalidValue("Digite um telefone para contato.");

            if (phoneNumber.Length < 11)
                return BaseDtoExtension.InvalidValue("Digite um telefone válido para contato.");

            UserEntity userEntity = Factory.CreateUserEntity(name, email, password, phoneNumber);

            _userRepository.Add(userEntity);

            return BaseDtoExtension.Sucess();
        }

        /// <summary>
        /// Responsável pelo registro do cliente.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="cpf"></param>
        /// <returns>Retorna <see cref="BaseDto"/> em caso de sucesso ou falha.</returns>
        public BaseDto Client(string name, string email, string cpf)
        {
            if (string.IsNullOrEmpty(name))
                return BaseDtoExtension.InvalidValue("Nome Inválido");

            if (string.IsNullOrEmpty(email))
                return BaseDtoExtension.InvalidValue("Email Inválido");

            if (!email.Contains("@") || !email.ToUpper().Contains(".COM"))
                return BaseDtoExtension.InvalidValue("Email Inválido");

            if (cpf.Length < 11)
                return BaseDtoExtension.InvalidValue("CPF Inválido");

            ClientEntity clientEntity = Factory.CreateClientEntity(name, cpf, email);

            _clientRepository.Add(clientEntity);

            return BaseDtoExtension.Sucess();
        }


    }
}
