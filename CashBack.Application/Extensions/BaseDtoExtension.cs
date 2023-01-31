using Cashback.Application.Dto;

namespace Cashback.Application.Extensions
{
    public class BaseDtoExtension
    {
        public static BaseDto CreateBaseDto(int statusCode, string message, object? data = null)
        {
            return new BaseDto(statusCode, message, data);
        }
    }
}
