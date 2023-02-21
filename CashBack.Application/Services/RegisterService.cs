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
        private readonly IBaseRepository<ClientEntity> _indicatedRepository;
        private readonly ProcedimentService _procedimentService;
        public RegisterService(IBaseRepository<UserEntity> userRepository, IBaseRepository<ClientEntity> indicatedRepository)
        {
            _userRepository = userRepository;
            _procedimentService = new(_userRepository);
            _indicatedRepository = indicatedRepository;
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
            var isExistentClient = user.Clients.Exists(x => x.CPF == cpf);

            if (isExistentClient)
                return BaseDtoExtension.Create(406, "Cliente já cadastrado", false);

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

        public BaseDto ClientWithoutProcediment(IndicatedEntity indicated, UserEntity user)
        {
            var isIndicated = user.Indicateds.Find(x => x.CPF == indicated.CPF);
            var indicatorName = "";

            if (isIndicated == null)
            {
                var indicator = user.Clients.Find(x => x.Name == indicated.IndicatorName);

                if (indicator == null)
                    return BaseDtoExtension.NotFound("indicador");

                indicatorName = indicator.Name;

                indicator.Indicateds.Add(indicated);

                user.Indicateds.Add(indicated);

                user.Clients.Remove(indicator);

                user.Clients.Add(indicator);

            }
            return BaseDtoExtension.Sucess($"Cliente {indicated.Name} cadastrado e dado crédito a {indicatorName}");
        }
        public BaseDto ClientWithProcediment(IProcediment procediment, UserEntity user)
        {
            var registerClient = Client(procediment.NamePacient, procediment.PhoneNumber, procediment.CPFClient, user);

            if (!registerClient._Condition)
                return BaseDtoExtension.InvalidValue(registerClient._Message);

            var procedimentResult = _procedimentService.Register(procediment, user);

            if (!procedimentResult._Condition)
                return BaseDtoExtension.InvalidValue(registerClient._Message);

            procediment.Client.Account.Balance += 20;

            return BaseDtoExtension.Sucess($"Cliente {procediment.Client.Name} e procedimento {procediment.Name} cadastros");
        }
    }
}