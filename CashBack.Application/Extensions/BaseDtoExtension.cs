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
        public static BaseDto Create(int statusCode, string message, bool condition, object? data = null) => new(statusCode, message, data, condition);
        public static BaseDto NotFound(string message = "Usuário") => new(404, $"{message} não encontrado", false);
        public static BaseDto InvalidValue(string message = "Valor inválido") => new(406, message, false);
        public static BaseDto Sucess(string message = "Operação conclúida") => new(200, message, true);
        public static BaseDto Error(int statusCode = 400, string message = "Não foi possível efetuar sua solicitação") => new(statusCode, message, false);
    }
}