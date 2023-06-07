using Microsoft.AspNetCore.Mvc;
using Service.Layer.Abstracts;

namespace Presentation.Layer.Controllers
{
    [ApiController]
    [Route("api/coursedetails")]
    public class CourseDetailController : ControllerBase
    {
        private readonly IServiceManager _manager;
        public CourseDetailController(IServiceManager manager)
        {
            _manager=manager;
        }

        [HttpGet] 
        public async Task<IActionResult> GetDetails()
        {
            return BadRequest();
        }
    }
}
