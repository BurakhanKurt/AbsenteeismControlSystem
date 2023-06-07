using Entities.Layer.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Layer.Abstracts;


namespace Presentation.Layer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public CourseController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpPost(Name = "CreateOneCourseAsync")]
        public async Task<IActionResult> CreateOneCourseAsync (int userId,[FromBody]Course course)
        {
            await _serviceManager.CourseServices.CreateOneCourseAsync(course);
            return StatusCode(201,course);
        }

        


    }
}
