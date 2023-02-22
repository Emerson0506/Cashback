using Cashback.Application.Services;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Casback.Tests.ServicesTests
{
    public class CalculateServiceTest
    {
        [Fact]
        public void CalculateCashback_ShouldReturnValidValue_WhenCalculated()
        {
            //Act
            var actual = CalculateService.CalculateCashback(500);
            var expected = 10;
            //Acert

            Assert.Equal(expected, actual);
        }

    }
}
