using Microsoft.Extensions.Hosting;

namespace Cashback.Application
{
    public interface IProvide
    {
        public IHost Hosting { get; }
    }
}