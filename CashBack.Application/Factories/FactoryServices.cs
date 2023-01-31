using Cashback.Application.Interfaces;
using Cashback.Application.Services;
using Cashback.Domain.Entities;
using Cashback.Repository.Interfaces;

namespace Cashback.Application.Factories
{
    /// <summary>
    /// Responsável pela inicialização dos serviços em <see cref="Cashback.Application.Services"/>
    /// </summary>
    public class FactoryServices
    {

        private static readonly IBaseRepository<UserEntity> _repositories = FactoryRepositories.Instance().CreateUserRepository();

        /// <summary>
        /// Inicializa a classe <see cref="FactoryServices"/>
        /// </summary>
        /// <returns>Retorna <see cref="FactoryServices"/> </returns>
        public static FactoryServices Instance()
        {
            return new FactoryServices();
        }

        /// <summary>
        /// Inicializa a <see cref="LoginService"/> que implementa o contrato <see cref="ILogin"/>
        /// </summary>
        /// <returns></returns>
        public static ILogin CreateLoginService()
        {
            return new LoginService();
        }
    }
}