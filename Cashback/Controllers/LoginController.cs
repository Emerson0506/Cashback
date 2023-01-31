using Cashback.Application.Dto;
using Cashback.Application.General;
using Cashback.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Cashback.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class LoginController : ControllerBase
    {
        private readonly ILogin _service;

        public LoginController()
        {
            _service = FactoryServices.CreateLoginService();
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult ExecuteLogin([FromBody] LoginDto loginDto)
        {
            BaseDto result = _service.ExecuteLogin(loginDto.Email, loginDto.Password);

            return StatusCode(result._StatusCode, result._Data == null ? new { result._Message } : result._Data);
        }
    }
}