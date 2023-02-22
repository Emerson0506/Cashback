using Cashback.Application.Extensions;
using Cashback.Application.Services;
using Cashback.Domain.Entities;
using Cashback.Repository.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casback.Tests.ServicesTests
{
    public class RegisterServiceTest
    {
        private readonly Mock<IBaseRepository<UserEntity>> _userRepositoryMock = new Mock<IBaseRepository<UserEntity>>();
        private readonly Mock<IBaseRepository<ClientEntity>> _clientRepositoryMock = new Mock<IBaseRepository<ClientEntity>>();
        private readonly RegisterService _registerService;

        public RegisterServiceTest()
        {
            _registerService = new(_userRepositoryMock.Object, _clientRepositoryMock.Object);
        }

        [Fact]

        public void Client_ShouldFalse_When_ClientAlreadyRegistered()
        {
            //Arrange

            ClientEntity client = new("Emer", "11434842908", null);
            var cpf = "11434842908";
            UserEntity user = new("Emerson", "emerson@gmail.com", "123456", "47991995238");
            user.Clients.Add(client);

            //Act

            var actual = _registerService.Client(null, null, cpf, user);

            var expected = BaseDtoExtension.Create(406, "Cliente já cadastrado", false);

            //Assert

            Assert.Equal(expected._Message, actual._Message);
            Assert.Equal(expected._StatusCode, actual._StatusCode);

        }


    }
}
