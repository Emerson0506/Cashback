using Cashback.Application.Dto;
using Cashback.Application.Extensions;
using Cashback.Domain.Entities;
using Cashback.Domain.Interfaces;
using Cashback.Repository.Interfaces;

namespace Cashback.Application.Services
{
    public class ProcedimentService
    {
        private readonly IBaseRepository<UserEntity> _userRepository;

        public ProcedimentService(IBaseRepository<UserEntity> userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary>
        /// Efetua o cadastro do <paramref name="procediment"/> e salva o valor do cashback na <see cref="CashbackEntity"/> e na conta do <paramref name="client"/>
        /// </summary>
        /// <param name="procediment"></param>
        /// <param name="user"></param>
        /// <param name="client"></param>
        /// <returns></returns>
        public BaseDto Register(IProcediment procediment, UserEntity user)
        {
            if (string.IsNullOrEmpty(procediment.NamePacient))
                return BaseDtoExtension.Error(406, "Nome do paciente inválido.");

            if (string.IsNullOrEmpty(procediment.CPFClient) || procediment.CPFClient.Length > 11)
                return BaseDtoExtension.InvalidValue();

            if (procediment.Value <= 0)
                return BaseDtoExtension.InvalidValue();

            if (string.IsNullOrEmpty(procediment.Name))
                return BaseDtoExtension.Error(406, "Procedimento inválido");

            if (string.IsNullOrEmpty(procediment.PhoneNumber))
                return BaseDtoExtension.InvalidValue("Telefone inválido");

            if (user == null)
                return BaseDtoExtension.NotFound();

            var procedimentEntity = new ProcedimentEntity(procediment.Value, procediment.Name,
                procediment.CPFClient, procediment.NamePacient, procediment.PhoneNumber, procediment.Client);

            var isSucess = SaveCashbackValue(procediment);

            if (!isSucess._Condition)
                return BaseDtoExtension.Create(isSucess._StatusCode, isSucess._Message, isSucess._Condition);

            user.Procediments.Add(procedimentEntity);

            _userRepository.Update(user.Id, user);

            return BaseDtoExtension.Create(200, $"PROCEDIMENTO {procediment.Name} REGISTRADO PARA O PACIENTE " +
                $"{procediment.NamePacient} NO VALOR DE {procediment.Value}", true);
        }

        public BaseDto SaveCashbackValue(IProcediment procediment)
        {
            if (procediment.Client == null || procediment == null)
                return BaseDtoExtension.Error(406, "Cliente ou procedimento inválido");

            var cashAmount = CalculateService.CalculateCashback(procediment.Value);

            procediment.Client.Account.Balance += cashAmount;

            return BaseDtoExtension.Sucess();
        }
    }
}