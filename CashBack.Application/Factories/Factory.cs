using Cashback.Application.Dto;
using Cashback.Domain.Entities;
using System.Xml.Linq;

namespace Cashback.Application.Factories
{
    /// <summary>
    /// Facilita a criação das entidades dentro de <see cref="Cashback.Domain.Entities"/>
    /// </summary>
    public static class Factory
    {
        /// <summary>
        /// Executa a criação de <see cref="UserEntity"/>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="cashback"></param>
        /// <returns>Retornando <see cref="UserEntity"/> com os parâmetros fornecidos.</returns>
        public static UserEntity CreateUserEntity(string name, string email, string password, string phoneNumber) => new UserEntity(name, email, password, phoneNumber);

        public static ClientEntity CreateClientEntity(string name, string cpf, string email) => new ClientEntity(name, cpf, email); 
    }
}