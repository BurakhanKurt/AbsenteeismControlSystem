using Entities.Layer.Models;
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

        [HttpPut("{id:int}")] 
        public async Task<IActionResult> UpdateDetailAsync([FromRoute(Name = "id")]int id,
            [FromBody]CourseDetail courseDetail)
        {
            await _manager
                .CourseDetailService
                .UpdateOneCourseDetailAsync(id,courseDetail,false);
            return Ok(courseDetail);
        }
    }
}
