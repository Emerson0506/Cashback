using Cashback.Application.Dto;

namespace Cashback.Application.Interfaces
{
    public interface ILogin
    {
        /// <summary>
        /// Executa o login do usuário com os parâmetros fornecidos.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns>Retorna <see cref="BaseDto"/> em caso de sucesso ou falha.</returns>
        public BaseDto ExecuteLogin(string email, string password);
    }
}