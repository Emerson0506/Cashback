namespace Cashback.Application.Dto
{
    public class BaseDto
    {
        public int _StatusCode { get; set; }
        public string _Message { get; set; }
        public object _Data { get; set; }
        public bool _Condition { get; set; }

        public BaseDto(int statusCode, string message, object data, bool condition)
        {
            _StatusCode = statusCode;
            _Message = message;
            _Data = data;
            _Condition = condition;
        }

        public BaseDto(int statusCode, string message, bool condition)
        {
            _StatusCode = statusCode;
            _Message = message;
            _Condition = condition;
        }
    }
}