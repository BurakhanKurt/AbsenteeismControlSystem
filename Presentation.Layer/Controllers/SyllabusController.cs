
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Abstracts;
using Service.Concretes;
using System.Net;

namespace Presentation.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    [Route("api/[controller]")]
    public class SyllabusController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public SyllabusController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetSyllabusAsync()
        {
            var userId = TokenHelper.GetUserIdFromToken(HttpContext.User);

            var syllabusDto = await _serviceManager
                .SyllebusService
                .GetSyllabusAsyncByUserIdAsync(userId, false);

            return Ok(syllabusDto);
        }
    }
}
