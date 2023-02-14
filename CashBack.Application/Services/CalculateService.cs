namespace Cashback.Application.Services
{
    internal class CalculateService
    {
        private static int _percentual { get; set; } = 2;

        public static decimal CalculateCashback(decimal value) => value * (_percentual / 100);
    }
}