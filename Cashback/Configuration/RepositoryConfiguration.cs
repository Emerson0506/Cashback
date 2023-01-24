using Cashback.Repository.Repositories;

namespace Cashback.Configuration
{
    public class RepositoryConfiguration
    {
        public static void Setup(IServiceCollection builder)
        {
            builder.AddSingleton<UserRepository>();
        }
    }
}