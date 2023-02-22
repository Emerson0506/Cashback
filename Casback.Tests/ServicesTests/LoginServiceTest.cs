using Cashback.Application.Extensions;
using Cashback.Application.Services;
using Cashback.Domain.Entities;
using Cashback.Repository.Interfaces;
using Moq;

namespace Casback.Tests.ServicesTests
{
    public class LoginServiceTest
    {
        private readonly Mock<IBaseRepository<UserEntity>> _userRepositoryMock = new Mock<IBaseRepository<UserEntity>>();
        private readonly LoginService _service;

        public LoginServiceTest()
        {
            _service = new(_userRepositoryMock.Object);
        }


        [Fact]
        public void ExecuteLogin_ShouldFail_WhenUserNotFound()
        {
            //Arrange
            _userRepositoryMock.Setup(x => x.GetAll()).Returns(new List<UserEntity>());


            //Act
            var actual = _service.ExecuteLogin(null, null);

            var expected = BaseDtoExtension.NotFound();


            //Assert
            Assert.Equal(expected._Message, actual._Message);
            Assert.Equal(expected._StatusCode, actual._StatusCode);
        }

        [Fact]
        public void ExecuteLogin_ShouldBeSuccess_WhenUserExists()
        {
            //Arrange
            var users = new List<UserEntity>();

            var user = new UserEntity("carlos", "carlos@gmail.com", "carlos", null);

            users.Add(user);

            _userRepositoryMock.Setup(x => x.GetAll()).Returns(users);

            //Act
            var actual = _service.ExecuteLogin(user.Email, user.Password);

            var expected = BaseDtoExtension.Create(200, "Login executado", true, user.Id);

            //Assert
            Assert.Equal(expected._Message, actual._Message);
            Assert.Equal(expected._StatusCode, actual._StatusCode);
        }
    }
}