
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
                .RegisterUser(userForRegistrationDto);

            if(!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }
            return StatusCode(201);
        }
    }
}
