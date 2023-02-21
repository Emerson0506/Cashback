using Cashback.Application.Services;
using Cashback.Domain.Entities;
using Cashback.Repository.Interfaces;
using Moq;

namespace Casback.Tests
{
    public class LoginServiceTest
    {
        private readonly LoginService _loginService;
        private readonly Mock<IBaseRepository<UserEntity>> mock = new Mock<IBaseRepository<UserEntity>>();

        public LoginServiceTest()
        {
            _loginService = new(mock.Object);
        }

        [Fact]
        public void login()
        {
            var users = new List<UserEntity>();

            mock.Setup(x => x.GetAll()).Returns(users);

            var actual = _loginService.ExecuteLogin("pedro@gmail.com","pedro");

            Assert.Equal(404, actual._StatusCode);
        }
    }
}