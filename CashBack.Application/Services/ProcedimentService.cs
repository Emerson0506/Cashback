using Cashback.Application.Dto;
using Cashback.Application.Extensions;
using Cashback.Application.Factories;
using Cashback.Domain.Entities;
using Cashback.Domain.Interfaces;
using Cashback.Repository.Interfaces;

namespace Cashback.Application.Services
{
    public class ProcedimentService
    {
        private readonly IBaseRepository<UserEntity> _userRepository;

        public ProcedimentService()
        {
            _userRepository = FactoryRepositories.Instance().CreateUserRepository();
        }

        public BaseDto Register(IProcediment procediment, Guid id)
        {
            if (string.IsNullOrEmpty(procediment.CPFClient) || procediment.CPFClient.Length > 11)
                return BaseDtoExtension.CreateBaseDto(406, "Valor Inválido");

            if (string.IsNullOrEmpty(procediment.Value.ToString()))
                return BaseDtoExtension.CreateBaseDto(406, "Valor Inválido");

            if (string.IsNullOrEmpty(procediment.Name))
                return BaseDtoExtension.CreateBaseDto(406, "Procedimento inválido");

            var procedimentEntity = new ProcedimentEntity(procediment.Value, procediment.Name, procediment.CPFClient, procediment.NamePacient);

            var user = _userRepository.GetById(id);

            if (user == null)
                return BaseDtoExtension.CreateBaseDto(404, "Usuario não encontrado");

            user.Procediments.Add(procedimentEntity);

            return BaseDtoExtension.CreateBaseDto(200, $"PROCEDIMENTO {procediment.Name} SALVO PARA O PACIENTE {procediment.NamePacient}");
        }
    }
}