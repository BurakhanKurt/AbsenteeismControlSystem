
using Entities.DTOs.UserDtos;
using Microsoft.AspNetCore.Mvc;
using Service.Abstracts;

namespace Presentation.Controllers
{

    [ApiController]
    [Route("api/authentication")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IServiceManager _manager;
        public AuthenticationController(IServiceManager manager)
        {
            _manager=manager;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser(
            [FromBody] UserForRegistrationDto userForRegistrationDto)
        {
            var result = await _manager
                .AuthenticationService
                .RegisterUserAsync(userForRegistrationDto);

            if(!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }

            var userForAuthDto = new UserForAuthenticationDto()
            {
                UserName = userForRegistrationDto.UserName,
                Password = userForRegistrationDto.Password,
            };

            if(!await _manager.AuthenticationService.ValidateUserAsync(userForAuthDto))
                return Unauthorized();

            var token = _manager
                .AuthenticationService
                .CreateToken();

            return Ok(token);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Authenticate(
            [FromBody] UserForAuthenticationDto userForAuthenticationDto)
        {
            if (!await _manager.AuthenticationService.ValidateUserAsync(userForAuthenticationDto))
                return Unauthorized();

            var token = _manager
                .AuthenticationService
                .CreateToken();

            return Ok(token);
        }

    }
}
