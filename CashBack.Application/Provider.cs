using Microsoft.Extensions.Hosting;

namespace Cashback.Application
{
    public class Provider : IProvide
    {
        public IHost Hosting { get; private set; }
        private readonly ISetup _setup;

        public Provider(IConfiguration configuration)
        {
            _setup = new Setup(configuration);  
            Hosting = CreateHostBuilder().Build();
        }
        public IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder().ConfigureServices((context, services) => { _setup.Inject(services); });
        }
    }
}