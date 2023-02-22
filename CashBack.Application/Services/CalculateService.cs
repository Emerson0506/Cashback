namespace Cashback.Application.Services
{
    public class CalculateService
    {
        private static decimal _percentual { get; set; } = 2;

        public static decimal CalculateCashback(decimal value) => value * (_percentual / 100);
    }
}