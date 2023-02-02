namespace Cashback.Application.Services
{
    internal class CalculateService
    {
        private int _percentual { get; set; } = 2;

        public decimal CalculateCashback(decimal value) => value * (_percentual / 100);

    }
}
