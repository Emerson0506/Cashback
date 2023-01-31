using Cashback.Application.Dto;

namespace Cashback.Application.Extensions
{
    /// <summary>
    /// Facilita a criação da <see cref="BaseDto"/>
    /// </summary>
    public class BaseDtoExtension
    {
        /// <summary>
        /// Executa a criação da <see cref="BaseDto"/>
        /// </summary>
        /// <param name="statusCode"></param>
        /// <param name="message"></param>
        /// <param name="data"></param>
        /// <returns>Retorna <see cref="BaseDto" /> com os parâmetros fornecidos</returns>
        public static BaseDto CreateBaseDto(int statusCode, string message, object? data = null)
        {
            return new BaseDto(statusCode, message, data);
        }
    }
}
