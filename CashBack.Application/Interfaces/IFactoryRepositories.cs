using Cashback.Domain.Entities;
using Cashback.Repository.Interfaces;

namespace Cashback.Application.Interfaces
{
    /// <summary>
    /// Contrato para a geração de repositórios.
    /// </summary>
    public interface IFactoryRepositories
    {
        /// <summary>
        /// Executa a implementação do repositório do tipo <see cref="UserEntity"/> 
        /// </summary>
        /// <returns>Retorna o repositório funcionando com a entidade <see cref="UserEntity"/></returns>

        IBaseRepository<UserEntity> CreateUserRepository();
    }
}
