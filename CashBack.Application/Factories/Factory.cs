using Cashback.Application.Dto;
using Cashback.Domain.Entities;

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
        public static UserEntity CreateUserEntity(string name, string email, string password, string phoneNumber, CashbackEntity cashback)
        {
            return new UserEntity(name, email, password, phoneNumber, cashback);
        }
    }
}