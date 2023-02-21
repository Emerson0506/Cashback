using Cashback.Application.Dto;
using Cashback.Application.Extensions;
using Cashback.Domain.Entities;
using Cashback.Domain.Interfaces;
using Cashback.Repository.Interfaces;

namespace Cashback.Application.Services
{
    /// <summary>
    /// Contém itens referentes as indicações
    /// </summary>
    internal class IndicateService
    {
        private readonly IBaseRepository<UserEntity> _userRepository;
        private readonly IBaseRepository<IndicatedEntity> _indicatesRepository;
        private IUser _user;

        public IndicateService(IBaseRepository<UserEntity> userRepository, IBaseRepository<IndicatedEntity> indicatesRepository)
        {
            _userRepository = userRepository;
            _indicatesRepository = indicatesRepository;
        }



        /// <summary>
        /// Efetua a indicação das pessoas fornecidas na lista para o usuario indicado com o parâmetro <paramref name="userID"/>
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="indicateds"></param>
        /// <returns>Retorna <see cref="BaseDto"/> com o número de indicados ou 404</returns>
        public BaseDto Indicate(Guid userID, List<IndicatedEntity> indicateds)
        {
            _user = _userRepository.GetById(userID);

            if (_user == null)
                return BaseDtoExtension.NotFound();

            var alreadyIndicateds = new List<IndicatedEntity>();

            var indicatesNumber = 0;

            foreach (var indicated in indicateds)
            {
                if (_indicatesRepository.GetById(indicated.Id) == null)
                {
                    _user.Indicateds.Add(indicated);
                    _indicatesRepository.Add(indicated);

                    indicatesNumber++;
                }

                else
                {
                    alreadyIndicateds.Add(indicated);
                }
            }

            if (alreadyIndicateds.Count > 0)
                return BaseDtoExtension.Create(200, $"NÃO FOI POSSIVEL INDICAR {alreadyIndicateds.Count} " +
                    $"PESSOAS POIS JÁ FORAM INDICADOS, E VOCÊ INDICOU {indicatesNumber} PESSOAS", false);

            return BaseDtoExtension.Create(200, $"{indicatesNumber} PESSOAS FORAM INDICADOS(A) COM SUCESSO", true);
        }
    }
}