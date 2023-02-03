using Cashback.Application.Dto;
using Cashback.Application.Extensions;
using Cashback.Application.Factories;
using Cashback.Domain.Entities;
using Cashback.Domain.Interfaces;
using Cashback.Repository.Interfaces;
using Cashback.Repository.Repositories;

namespace Cashback.Application.Services
{
    /// <summary>
    /// Responsável pelos registros do usuário e do cliente.
    /// </summary>
    public class RegisterService 
    {
        private readonly IBaseRepository<UserEntity> _userRepository = FactoryRepositories.Instance().CreateUserRepository();
        private readonly IBaseRepository<ClientEntity> _clientRepository = FactoryRepositories.Instance().CreateClientRepository();

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

            if(password.Length < 3)
                return BaseDtoExtension.InvalidValue("Digite uma senha segura!");

            if (string.IsNullOrEmpty(phoneNumber))
                return BaseDtoExtension.InvalidValue("Digite um telefone para contato.");

            if(phoneNumber.Length < 11)
                return BaseDtoExtension.InvalidValue("Digite um telefone válido para contato.");

            UserEntity userEntity = Factory.CreateUserEntity(name, email, password, phoneNumber); 

            _userRepository.Add(userEntity);

            return BaseDtoExtension.Sucess();
        }

        public BaseDto User(string name, string email, string cpf)
        {
            if (string.IsNullOrEmpty(name))
                return BaseDtoExtension.InvalidValue("Nome Inválido");

            if (string.IsNullOrEmpty(email))
                return BaseDtoExtension.InvalidValue("Email Inválido");

            if (!email.Contains("@") || !email.ToUpper().Contains(".COM"))
                return BaseDtoExtension.InvalidValue("Email Inválido");

            if(cpf.Length < 11)
                return BaseDtoExtension.InvalidValue("CPF Inválido");

            UserEntity userEntity = Factory.CreateClientEntity(name, email);

            _userRepository.Add(userEntity);

            return BaseDtoExtension.Sucess();
        }


    }
}
