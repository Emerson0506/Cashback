using Cashback.Application.Interfaces;
using Cashback.Domain.Entities;
using Cashback.Repository.Interfaces;
using Cashback.Repository.Repositories;

namespace Cashback.Application.Factories
{
    /// <summary>
    /// Executa a criação dos repositórios em <see cref="Cashback.Repository.Repositories"/>
    /// 
    /// <para>Implementa <see cref="IFactoryRepositories"/></para>
    /// </summary>
    public class FactoryRepositories : IFactoryRepositories
    {
        /// <summary>
        /// Inicializa a classe <see cref="FactoryRepositories"/>
        /// </summary>
        /// <returns>Retornando <see cref="FactoryRepositories"/></returns>
        public static FactoryRepositories Instance() => new FactoryRepositories();

        /// <summary>
        /// Inicializa a classe <see cref="UserRepository"/>
        /// </summary>
        /// <returns>Retorna o contrato implementado por <see cref="UserRepository"/></returns>
        public IBaseRepository<UserEntity> CreateUserRepository() => new UserRepository();

        /// <summary>
        /// Inicializa a classe <see cref="ClientRepository"/>
        /// </summary>
        /// <returns>Retorna o contrato implementado por <see cref="ClientRepository"/></returns>
        public IBaseRepository<ClientEntity> CreateClientRepository() => new ClientRepository();

    }
}