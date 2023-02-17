using Cashback.Application.Dto;
using Cashback.Application.Extensions;
using Cashback.Application.Factories;
using Cashback.Domain.Entities;
using Cashback.Domain.Interfaces;
using Cashback.Repository.Interfaces;
using Cashback.Repository.Repositories;
using System.Security.Cryptography.X509Certificates;

namespace Cashback.Application.Services
{
    /// <summary>
    /// Responsável pelos registros do usuário e do cliente.
    /// </summary>
    public class RegisterService
    {
        private readonly IBaseRepository<UserEntity> _userRepository;
        public RegisterService(IBaseRepository<UserEntity> userRepository)
        {
            _userRepository = userRepository;
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
        /// <param name="user"></param>
        /// <param name="cpf"></param>
        /// <param name="phoneNumber"></param>
        /// <returns>Retorna <see cref="BaseDto"/> em caso de sucesso ou falha.</returns>
        public BaseDto Client(string name, string phoneNumber, string cpf, UserEntity user)
        {
            if (string.IsNullOrEmpty(name))
                return BaseDtoExtension.InvalidValue("Nome Inválido");

            if (string.IsNullOrEmpty(phoneNumber))
                return BaseDtoExtension.InvalidValue("Telefone Inválido");

            if (cpf.Length < 11)
                return BaseDtoExtension.InvalidValue("CPF Inválido");

            ClientEntity clientEntity = Factory.CreateClientEntity(name, cpf, phoneNumber);

            user.Clients.Add(clientEntity);

            _userRepository.Update(user.Id, user);

            return BaseDtoExtension.Sucess();
        }

        public BaseDto ClientWithoutProcediment(List<IndicatedEntity> indicateds, UserEntity user)
        {
            var toAdd = new List<IndicatedEntity>();

            foreach (var person in indicateds)
            {
                var result = user.Indicateds.Find(x => x.CPF == person.CPF);

                if (result == null)
                {
                    toAdd.Add(result);

                    var indicator = user.Clients.Find(x => x.Name == person.IndicatorName); // filtrar caso nulo.

                    indicator.Indicateds.Add(person);

                    user.Clients.Remove(indicator);
                    user.Clients.Add(indicator);

                }
            }
            user.Indicateds.AddRange(toAdd);
        }
    }
}
