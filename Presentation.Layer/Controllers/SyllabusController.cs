using Microsoft.AspNetCore.Mvc;
using Service.Layer.Abstracts;

namespace Presentation.Layer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SyllabusController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public SyllabusController(IServiceManager manager)
        {
            _manager=manager;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetSyllabusAsync([FromRoute(Name = "id")] int id)
        {
            var syllabusDto = await _manager
                .SyllebusService
                .GetSyllabusAsyncByUserIdAsync(id, false);

            return Ok(syllabusDto);
        }
    }
}
